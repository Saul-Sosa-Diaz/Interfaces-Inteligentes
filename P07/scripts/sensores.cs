using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sensores : MonoBehaviour
{

    TMP_Text valueText;
    LocationInfo GPSdata;
    public GameObject samurai;

    // Start is called before the first frame update
    void Start()
    {
        // Habilitar los sensores
        Input.gyro.enabled = true;
        Input.compass.enabled = true;
        Input.location.Start();
        // Obtener el componente TMP_Text para mostrar los valores de los sensores
        valueText = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GPSdata = Input.location.lastData;
        valueText.text =
        $"Angular velocity: {Input.gyro.rotationRate}\nTrueHeading: {Input.compass.trueHeading}\nAcceleration: {Input.acceleration}\nLatitud: {GPSdata.latitude}\n" +
        $"Longitud: {GPSdata.longitude}\nAltitud: {GPSdata.altitude}\n";
        // Rotar el samurai en función de la orientación del dispositivo siempre al norte
        samurai.transform.rotation = Quaternion.Slerp(samurai.transform.rotation, Quaternion.Euler(0,-Input.compass.trueHeading,0), 0.5f);
    }
}

