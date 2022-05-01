using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Rigidbody Faca_Rigidbody;
    public MeshCollider Faca_Collider;
    private bool Eh_Mobile = false;
    void Start()
    {
        Faca_Rigidbody = GetComponent<Rigidbody>();
        Eh_Mobile = Application.platform == RuntimePlatform.Android;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || (Eh_Mobile && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Faca_Rigidbody.AddForce(new Vector3(70f, 300f, 0f));
            Faca_Rigidbody.AddTorque(new Vector3(0f, 0f, -30f));
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other);
        if (other.gameObject.GetComponent<ObjetoFatiavel>() != null)
        {
            other.gameObject.GetComponent<ObjetoFatiavel>().Fatiar();
        }
    }
}
