using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EixoCamera : MonoBehaviour
{
    public Rigidbody player_Rigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player_Rigidbody.transform.position;
    }
}
