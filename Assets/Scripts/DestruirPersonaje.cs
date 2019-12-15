using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruirPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Personaje" || obj.gameObject.name == "Pistola")
        {
            //Destroy(obj.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
