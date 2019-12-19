﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContarVida : MonoBehaviour


{
    public AudioClip sonidoArma;
    AudioSource audio;




    int ContadorVida;
    public Text puntuacionvida;
    public void Awake()
    {
        ContadorVida = 3;
        actualizar();
        if (PlayerPrefs.HasKey("dato2"))
        {
            int info = PlayerPrefs.GetInt("dato2");
            Debug.Log("Guarda 23: " + info);
            puntuacionvida.text = "Vida: ( " + info + " / 3 )";
        }
    }


   //  void Start()
   // {
       
    //}
    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Zombie 1")
        {
            //Destroy(obj.gameObject);
            ContadorVida -= 1;
            audio = GetComponent<AudioSource>();

            audio.clip = sonidoArma;
            audio.Play();
            actualizar();

            Guardar(ContadorVida);

            if (ContadorVida <= 0)
            {
                
                SceneManager.LoadScene("GameOver");
              // ContadorVida = 3;
               actualizar();
            }
        }
    }
    public void actualizar()
    {
        puntuacionvida.text = "Vida: ( " + ContadorVida + " / 3 )";
        //if(UnityEngine.Application.UnloadLevel('1'))
        //{
        //    Depuracion.Log("borrado los datos");
        //    player
        //}
    }
    void Guardar(int contador)
    {
        PlayerPrefs.SetInt("dato2", contador);
        Debug.Log("Guarda");
        if (PlayerPrefs.HasKey("dato2"))
        {

            int info = PlayerPrefs.GetInt("dato2");
            Debug.Log("Guardado: " + info);
        }
    } 
}
