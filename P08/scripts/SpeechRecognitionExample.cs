using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

namespace HuggingFace.API.Examples {
    public class SpeechRecognitionExample : MonoBehaviour {
        [SerializeField] private Button startButton;
        [SerializeField] private Button stopButton;
        [SerializeField] private TextMeshProUGUI text;

        private AudioClip clip;
        private byte[] bytes;
        private bool recording;
        private int arana = 0;
        private GameObject[] aranas;
        public GameObject indicador;
        

        private void Start() {
            stopButton.interactable = false;
            aranas = GameObject.FindGameObjectsWithTag("araña");
        }

        private void Update() {
            Debug.Log(arana);
            if (Input.GetKeyDown(KeyCode.Space)) {
                StartRecording();
            } 
            if (Input.GetKeyUp(KeyCode.Space)) {
                StopRecording();
            }
            if (recording && Microphone.GetPosition(null) >= clip.samples) {
                StopRecording();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow)) {
                arana++;
                if (arana >= aranas.Length) {
                    arana = 0;
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                arana--;
                if (arana < 0) {
                    arana = aranas.Length - 1;
                }
            }
            indicador.transform.position = aranas[arana].transform.position + new Vector3(0f,0.5f,0f);
        }

        private void StartRecording() {
            text.color = Color.white;
            text.text = "Recording...";
            startButton.interactable = false;
            stopButton.interactable = true;
            clip = Microphone.Start(null, false, 10, 44100);
            recording = true;
        }

        private void StopRecording() {
            var position = Microphone.GetPosition(null);
            Microphone.End(null);
            var samples = new float[position * clip.channels];
            clip.GetData(samples, 0);
            bytes = EncodeAsWAV(samples, clip.frequency, clip.channels);
            recording = false;
            SendRecording();
        }

        private void SendRecording() {
            text.color = Color.yellow;
            text.text = "Sending...";
            stopButton.interactable = false;
            HuggingFaceAPI.AutomaticSpeechRecognition(bytes, response => {
                Rigidbody rb = aranas[arana].GetComponent<Rigidbody>(); // Seleccionar la araña que toca
                text.color = Color.white;
                text.text = response;
                response = response.ToLower();
                response =  Regex.Replace(response, @"[^A-Za-z0-9]+", ""); // Eliminar caracteres especiales
                if (response.Contains("jump")) {        // Salta
                    Vector3 direction = new Vector3(0f,1f,0f);
                    rb.AddForce(direction*6f, ForceMode.Impulse); 
                } else if (response.Contains("left")) {  // Izquierda
                    Vector3 direction = new Vector3(-1f,0f,0f);
                    rb.AddForce(direction*6f, ForceMode.Impulse);
                } else if (response.Contains("right")) {  // Derecha
                    Vector3 direction = new Vector3(1f,0f,0f);
                    rb.AddForce(direction*6f, ForceMode.Impulse);
                } 
                startButton.interactable = true;
            }, error => {
                text.color = Color.red;
                text.text = error;
                startButton.interactable = true;
            });
        }

        private byte[] EncodeAsWAV(float[] samples, int frequency, int channels) {
            using (var memoryStream = new MemoryStream(44 + samples.Length * 2)) {
                using (var writer = new BinaryWriter(memoryStream)) {
                    writer.Write("RIFF".ToCharArray());
                    writer.Write(36 + samples.Length * 2);
                    writer.Write("WAVE".ToCharArray());
                    writer.Write("fmt ".ToCharArray());
                    writer.Write(16);
                    writer.Write((ushort)1);
                    writer.Write((ushort)channels);
                    writer.Write(frequency);
                    writer.Write(frequency * channels * 2);
                    writer.Write((ushort)(channels * 2));
                    writer.Write((ushort)16);
                    writer.Write("data".ToCharArray());
                    writer.Write(samples.Length * 2);

                    foreach (var sample in samples) {
                        writer.Write((short)(sample * short.MaxValue));
                    }
                }
                return memoryStream.ToArray();
            }
        }
    }
}