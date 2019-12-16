using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float VidaE = 100f;
    public float RestarVida = 50f;
    //Health health;
    public bool muerto = false;
    // Start is called before the first frame update
    void Start()
    {
     //   this.health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(VidaE <= 0)
        {
            muerto = true;
           
        }
    }
  

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Debug.Log("vidaE -- " + VidaE);
            VidaE -= RestarVida;
            //this.health.UpdateHPBar(this.RestarVida, this.VidaE);
        }
    }
}
