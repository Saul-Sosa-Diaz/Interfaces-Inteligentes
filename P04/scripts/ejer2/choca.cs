using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choca : MonoBehaviour
{
    public delegate void ChocaConAlgo();
    public event ChocaConAlgo ChocaConCualquieraNoTipo1;
    public event ChocaConAlgo ChocaConTipo1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if ( col.gameObject.tag != "Untagged" && col.gameObject.tag != "sphere_type_1" ) {  
            if (ChocaConCualquieraNoTipo1 != null) // Verificar si hay suscriptores antes de invocar el evento
            {
                ChocaConCualquieraNoTipo1();
            }
        } else if (col.gameObject.tag != "Untagged" && col.gameObject.tag == "sphere_type_1") {
            if (ChocaConTipo1 != null) // Verificar si hay suscriptores antes de invocar el evento
            {
                ChocaConTipo1();
            }
        }
    }
}
