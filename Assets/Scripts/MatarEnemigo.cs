using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision enemigo)
    {

        if (enemigo.gameObject.name == "Zombie 1")
        {
            Destroy(enemigo.gameObject);

        }
    }
}
