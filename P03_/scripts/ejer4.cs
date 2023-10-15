using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s (movimiento vertical) a-d (movimiento horizontal).




public class ejer4 : MonoBehaviour
{   
    public GameObject cube;
    public GameObject sphere;

    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 moveDirectionCube = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cube.transform.Translate(moveDirectionCube * speed, 0);

        Vector3 moveDirectionSphere = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2")); // cree un nuevo mapeo de teclas para la esfera
        sphere.transform.Translate(moveDirectionSphere * speed, 0);   
    }
}
