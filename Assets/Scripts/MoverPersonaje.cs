using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float VelocidadM = 01.0f;
    public float VelocidadR = 200.0f;
    private Animator Ani;
    public float x, y; // para saber si el personaje se esta moviendo o esta quieto
   
    void Start()
    {
        Ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * VelocidadR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * VelocidadM);
        Ani.SetFloat("VelX", x);
        Ani.SetFloat("VelY", y);
    }
}
