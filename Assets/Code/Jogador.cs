using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    private Rigidbody faca_rigidbody;
    private bool eh_mobile = false;
    void Start()
    {
        faca_rigidbody = GetComponent<Rigidbody>();
        eh_mobile = Application.platform == RuntimePlatform.Android;
    }

    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0) || (eh_mobile && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            faca_rigidbody.AddForce(new Vector3(70f, 300f, 0f));
            faca_rigidbody.AddTorque(new Vector3(0f, 0f, -30f));
        }
        if (faca_rigidbody.transform.position.y < -3)
        {
            reset_nivel();
        }
    }

    public void reset_nivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<ObjetoFatiavel>() != null)
        {
            other.gameObject.GetComponent<ObjetoFatiavel>().Fatiar();
        }
    }
}
