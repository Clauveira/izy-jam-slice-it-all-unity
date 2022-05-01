using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoFatiavel : MonoBehaviour
{
    public GameObject Fatia1;
    public GameObject Fatia2;
    private Rigidbody Fatia1_Rigidbody;
    private Rigidbody Fatia2_Rigidbody;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Fatiar()
    {
        if (GetComponent<Rigidbody>())
        {
            Destroy(GetComponent<Rigidbody>());
            Fatia1.AddComponent<Rigidbody>();
            Fatia2_Rigidbody = Fatia2.AddComponent<Rigidbody>();

            Fatia1_Rigidbody = Fatia1.GetComponent<Rigidbody>();
            Fatia2_Rigidbody = Fatia2.GetComponent<Rigidbody>();

            Fatia1_Rigidbody.mass = 0.1f;
            Fatia2_Rigidbody.mass = 0.1f;

            Fatia1_Rigidbody.AddForce(new Vector3(0f, 5f, 10f));
            Fatia2_Rigidbody.AddForce(new Vector3(0f, 5f, -10f));

        }
    }
}
