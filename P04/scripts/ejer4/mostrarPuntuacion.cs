using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarPuntuacion : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Cubo;
    public Text texto;
    puntuacion puntuacionObjeto;
    int puntuacion;
    void Start()
    {
        puntuacionObjeto = GameObject.FindWithTag("Cube").GetComponent<puntuacion>();
        texto.text = "Puntuación = 0";
        puntuacionObjeto.SubirPuntuacionEvento += ActualizarTexto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActualizarTexto() 
    {
       texto.text = "Puntuación = " + puntuacionObjeto.puntuacionActual.ToString(); 
    }
}
