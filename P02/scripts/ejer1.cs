/**
Crea un script asociado al cubo que inicialice un array a un conjunto de valores numéricos aleatorios entre 0 y 25. 
En cada frame se debe cambiar una posición aleatoria y mostrar en pantalla en la consola los que sean mayores que 15. 
Parametrizar el rango para poderlo cambiar desde el inspector.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1 : MonoBehaviour {
    public int[] range =  new int[2];
    public int size = 10;
    public int underBound = 15;
    int[] vect;
    
    // Start is called before the first frame update
    void Start() {
        if (underBound > range[1]) {
            Debug.Log("Change underbound, its to bigger compare to the greatest range.");

        } else {
            string vectorString = "";
            vect = new int[size];
            
            for (int i = 0; i < size; i++) {
                vect[i] = UnityEngine.Random.Range(range[0], range[1]);
                if (vect[i] >= 15) {
                    vectorString += $"{vect[i]} ";
                }
        }
        Debug.Log(vectorString);
        }
    }

    // Update is called once per frame
    void Update() {
        int indexToChange = UnityEngine.Random.Range(0, size);
        vect[indexToChange] = UnityEngine.Random.Range(range[0], range[1]);
        string vectorString = "";

        for (int i = 0; i < size; i++) {
            if (vect[i] >= 15) {
              vectorString += $"{vect[i]} ";
            }
        
        }
        Debug.Log(vectorString);
    }
}
