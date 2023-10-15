using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1_changeCOlor : MonoBehaviour
{
    public ejer1_notificador notificador;
    // Start is called before the first frame update
    void Start()
    {
      notificador.OnMiEvento += changeColor;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void changeColor() {
        GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.0f,0.9f),UnityEngine.Random.Range(0.0f,0.9f), UnityEngine.Random.Range(0.0f,0.9f));
    }
}
