using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirarAranaModificacion : MonoBehaviour
{
    public GameObject aranaA;
    public GameObject aranaB;
    public GameObject aranaC;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnPointerEnter()
    {
        Transform tamano = aranaB.GetComponent<Transform>();
        tamano.localScale += new Vector3(0.2f,0.2f,0.2f);

        Transform aranaA_t = aranaA.GetComponent<Transform>();
        aranaA_t.position = new Vector3(3.79021668f,3,1.04952443f);
        Debug.Log(aranaA_t.position);
        aranaC.GetComponent<Transform>().position = new Vector3(5f,3f,1.04952443f);
    }
}
