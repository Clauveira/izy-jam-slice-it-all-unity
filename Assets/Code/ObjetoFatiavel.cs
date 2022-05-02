using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoFatiavel : MonoBehaviour
{
    public GameObject fatia1;
    public GameObject fatia2;
    private Rigidbody fatia1_rigidbody;
    private Rigidbody fatia2_rigidbody;

    public float massa = 0.1f;

    void Start()
    {
    }

    void Update()
    {
    }

    public void Fatiar()
    {
        if (GetComponent<Rigidbody>())
        {
            Destroy(GetComponent<Rigidbody>());
            if (!fatia1.GetComponent<Rigidbody>())
            {
                fatia1.AddComponent<Rigidbody>();
                fatia1_rigidbody = fatia1.GetComponent<Rigidbody>();
                fatia1_rigidbody.mass = massa;
                fatia1_rigidbody.AddForce(new Vector3(0f, 5f, 10f));
            }
            if (!fatia2.GetComponent<Rigidbody>())
            {
                fatia2.AddComponent<Rigidbody>();
                fatia2_rigidbody = fatia2.GetComponent<Rigidbody>();
                fatia2_rigidbody.mass = massa;
                fatia2_rigidbody.AddForce(new Vector3(0f, 5f, -10f));
            }

        }
    }
}
