using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muerte : MonoBehaviour
{
    public delegate void Muerto();
    public event Muerto muertoEvent;
    public Text texto;  // Hay que agregar using UnityEngine.UI;
    // Start is called before the first frame update
    void Start()
    {
      texto.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Agua") {
            muertoEvent();
            texto.text = "Muerto";
        }
    }
}
