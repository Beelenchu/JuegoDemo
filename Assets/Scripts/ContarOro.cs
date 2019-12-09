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
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BolsaOro")
        {
            Destroy(other.gameObject);
            contador += 250;
            actualizar();
            if(contador == 3000)
            {
                SceneManager.LoadScene("Congratulations");
            }
        }
    }

    private void actualizar()
    {
        puntuacion.text = "Oro: " + contador + " pts / 3000 pts";
    }

}
