using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agrandar : MonoBehaviour
{
    public choca ChocaConAlgo; 
    // Start is called before the first frame update
    void Start()
    {
      ChocaConAlgo.ChocaConTipo1 += Agrandar;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Agrandar() {
        Transform tamano = GetComponent<Transform>();
        tamano.localScale += new Vector3(0.2f,0.2f,0.2f);
    }
}
