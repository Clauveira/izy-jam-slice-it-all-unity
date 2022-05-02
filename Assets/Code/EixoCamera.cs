using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EixoCamera : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    void Start()
    {

    }

    void Update()
    {
        transform.position = player_rigidbody.transform.position;
    }
}
