using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirarArana : MonoBehaviour
{
    int contador;
    // Start is called before the first frame update
    void Start() {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnPointerEnter()
    {
        
        contador++;
        Debug.Log(contador);
        if (contador == 2) {
            Destroy(gameObject);
            Destroy(this);
        }
    }

}
