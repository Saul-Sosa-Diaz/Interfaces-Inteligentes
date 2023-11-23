using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "araña") {
            AudioSource.Play();
            DestruirObjeto(col.gameObject);
        }
    }


    void DestruirObjeto(GameObject objeto) {
        Destroy(objeto);
    }
}
