using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContarOro : MonoBehaviour
{
   

    int contador;
    public Text puntuacion;

    public void Awake()
    {
      
        contador = 0;
        actualizar();
        if (PlayerPrefs.HasKey("dato1"))
        {
            int info = PlayerPrefs.GetInt("dato1");
            Debug.Log("Guarda 22: " + info);
            puntuacion.text = "Oro: " + info + " pts / 3000 pts";
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BolsaOro")
        {
            Destroy(other.gameObject);
            contador += 250;
            actualizar();

            Guardar(contador);

            if(contador == 3000)
            {
                SceneManager.LoadScene("Congratulations");
            }
        }
    }

    public void actualizar()
    {
        puntuacion.text = "Oro: " + contador + " pts / 3000 pts";
    }

    void Guardar(int contador)
    {
        PlayerPrefs.SetInt("dato1", contador);
        Debug.Log("GUarda");


        if (PlayerPrefs.HasKey("dato1"))
        {
            int info = PlayerPrefs.GetInt("dato1");
            Debug.Log("Guardaddo: " + info);
        }

    }

}
