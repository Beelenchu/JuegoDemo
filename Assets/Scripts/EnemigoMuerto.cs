using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuerto : MonoBehaviour
{
    
    GameObject[] monosList;

    //private GameController gameController;
    public int scoreValor;


    VidaEnemigo EnemigoVida;
    GameObject EnemigoMuertoG;
    // Start is called before the first frame update
    void Start()
    {
        //gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        EnemigoVida = GetComponent<VidaEnemigo>();
        
   
    }
    
    // Update is called once per frame
    void Update()
    {
     
        

        if (EnemigoVida.muerto == true)
        {
            //gameController.AddScore(scoreValor);
            Destroy(this.gameObject);
           
           // Debug.Log("eliminado");
            
        }
    }

    
   
}
