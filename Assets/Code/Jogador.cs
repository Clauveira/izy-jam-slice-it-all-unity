using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Rigidbody player_Rigidbody;
    private bool eh_mobile = false;
    void Start()
    {
        player_Rigidbody = GetComponent<Rigidbody>();
        eh_mobile = Application.platform == RuntimePlatform.Android;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || (eh_mobile && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            player_Rigidbody.AddForce(new Vector3(70f, 300f, 0f));
            player_Rigidbody.AddTorque(new Vector3(0f, 0f, -30f));
        }
    }
}
