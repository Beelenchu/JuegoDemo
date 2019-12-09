using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScObs_A_ScLab : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pistola")
        {
            SceneManager.LoadScene("Laberinto");
        }
    }
}
