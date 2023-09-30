using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            Material m_Material;
            m_Material = GetComponent<Renderer>().material;
            Color newColor = new Color(UnityEngine.Random.Range(0.0f,0.9f),UnityEngine.Random.Range(0.0f,0.9f), UnityEngine.Random.Range(0.0f,0.9f));
            m_Material.color = newColor;
        }
        
    }
}
