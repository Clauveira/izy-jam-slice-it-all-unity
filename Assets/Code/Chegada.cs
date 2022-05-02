using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chegada : MonoBehaviour
{
    public string proximo_nivel = "Assets/Scenes/Fase2.unity";
    private Rigidbody chegada_rigidbody;
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0.0f, 100.0f * Time.deltaTime, 0.0f, Space.Self);
    }
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(proximo_nivel);

    }
}
