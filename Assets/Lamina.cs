using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamina : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
