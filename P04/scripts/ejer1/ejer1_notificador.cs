using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1_notificador: MonoBehaviour
{
    public delegate void Choca();
    public event Choca OnMiEvento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if ( col.gameObject.tag == "Cylynder" ) {  
            if (OnMiEvento != null) // Verificar si hay suscriptores antes de invocar el evento
            {
                OnMiEvento();
            }
        }
    }
}