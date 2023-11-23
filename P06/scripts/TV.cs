using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{   
    private Material tvMaterial;
    public string path;
    private WebCamTexture webcamTexture;
    private int CaptureCounter = 1;
    private bool activeCam;
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
            Debug.Log("Camara: " + devices[i].name); // Show camera devices

        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        tvMaterial = GetComponent<Renderer>().material;
        path = "D:\\Cosas\\Descargas\\camara_audio\\Assets\\";
        activeCam = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey("s")) { // Active cam
        if (!activeCam)
          Debug.Log("Camara activa.");
          activeCam = true;
          tvMaterial.mainTexture = webcamTexture;
          webcamTexture.Play();
       }

       if (Input.GetKey("p")) { //Pause cam
         if (activeCam)
          Debug.Log("Camara inactiva.");
          activeCam = false;
          webcamTexture.Stop();
       }

       if (Input.GetKey("x")) { // Take snapshot
            if (activeCam) {
                Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height);
                snap.SetPixels(webcamTexture.GetPixels());
                snap.Apply();
                System.IO.File.WriteAllBytes(path + CaptureCounter.ToString() + ".png", snap.EncodeToPNG());
                ++CaptureCounter;
                Debug.Log("Guardada foto en:");
                Debug.Log(path + CaptureCounter.ToString());
            } else {
                Debug.Log("La cam debe estar activa.");
            }
       }
       
    }
}
