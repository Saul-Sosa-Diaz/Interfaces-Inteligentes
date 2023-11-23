using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Audio: " + device);
        }

        audioSource.clip = Microphone.Start(Microphone.devices[0], true, 10, 44100);
    }

    // Update is called once per frame
    void Update()
    {           
        if (Input.GetKey("n")) {
            audioSource.Play();
        }

        if (Input.GetKey("m")) {
            Microphone.End(Microphone.devices[0]);
        }
    }
}
