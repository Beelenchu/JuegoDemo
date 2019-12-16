using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class DestruirPersonaje : MonoBehaviour
{
    
    
    //public bool lockCursor = true;
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Personaje" || obj.gameObject.name == "Pistola")
        {
            cont++;
            Debug.Log("cont " + cont);
            //Destroy(obj.gameObject);
            if (cont == 3)
            {
                Destroy(obj.gameObject);
           
                SceneManager.LoadScene("GameOver");
            }
            
        }
    }
}
