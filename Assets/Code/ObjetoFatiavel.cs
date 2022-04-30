using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoFatiavel : MonoBehaviour
{
    public GameObject Fatia1;
    public GameObject Fatia2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Fatiar();
        }
    }

    public void Fatiar()
    {
        if (GetComponent<Rigidbody>())
        {
            Destroy(GetComponent<Rigidbody>());
            Fatia1.AddComponent<Rigidbody>();
            Fatia2.AddComponent<Rigidbody>();
        }
    }
}
