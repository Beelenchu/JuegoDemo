using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScObs_A_ScGameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Espada" || other.gameObject.tag == "Faraon" || other.gameObject.tag == "PisoLava" || other.gameObject.tag == "Zombie")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
