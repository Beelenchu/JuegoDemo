using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundo")]
    public int tiempoInicial;
    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f,10.0f)]
    public float escalaDeTiempo = 1;

   public Text myText;
    private float tiempoDelframeConTimeSacle = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado = false;

    void start()
    {
        escalaDeTiempoInicial = escalaDeTiempo;
        myText = GetComponent<Text>();
        tiempoAMostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);
    }

    void Update()
    {
        tiempoDelframeConTimeSacle = Time.deltaTime * escalaDeTiempo;
        tiempoAMostrarEnSegundos += tiempoDelframeConTimeSacle;
        ActualizarReloj(tiempoAMostrarEnSegundos);
    }

    public void ActualizarReloj(float tiempoEnSegundo)
    {
        int minuto = 0;
        int segundo = 0;
        string textoDelReloj;

        //if (tiempoEnSegundo > 120)
        //{
        //    //tiempoEnSegundo = 0;
        //    SceneManager.LoadScene("GameOver");
        //}
        {
            
        }
        minuto = (int)tiempoEnSegundo / 60;
        segundo = (int)tiempoEnSegundo % 60;

        textoDelReloj = minuto.ToString("00") + ":" + segundo.ToString("00");
        myText.text = textoDelReloj;
    }
}
