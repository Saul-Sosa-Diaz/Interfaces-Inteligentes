using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCamara : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject jugador;
    bool vivo;
    muerte muerteEvento;
    void Start()
    {
        vivo = true;
        jugador = GameObject.FindWithTag("Jugador");
        // Colocar la cámara en la posición del jugador
        transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
        muerteEvento = GameObject.FindWithTag("Jugador").GetComponent<muerte>();
        muerteEvento.muertoEvent += MoverCamara;
        
    }

    // Update is called once per frame
    void Update() {
        if (vivo) {
            transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, jugador.transform.position.z);
            transform.forward = jugador.transform.forward;
        }
    }

    // Método que se ejecuta cuando el jugador muere
    void MoverCamara(){
        vivo = false;
        transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y + 30, jugador.transform.position.z);
        transform.LookAt(jugador.transform.position);
    }
}
