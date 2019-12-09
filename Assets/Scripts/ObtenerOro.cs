using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerOro : MonoBehaviour
{

        GameObject[] monosList;
    private GameController gameController;
    public int scoreValor;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }


    private void OnCollisionEnter(Collision cosa)
    {

        if (cosa.gameObject.name == "BolsaGold")
        {
            Destroy(cosa.gameObject);
            gameController.AddScore(scoreValor);
        }
    }

}

