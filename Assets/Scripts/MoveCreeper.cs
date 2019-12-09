using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreeper : MonoBehaviour
{
    
    
    
    float posini;
    float posa;
   // float posRandom;
    // Start is called before the first frame update
    void Start()
    {
        posini = transform.position.x;
        posa = transform.position.z;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (posini == -13.46f)
        {
           
            transform.position = new Vector3(Mathf.PingPong(Time.time * 3, 15) + posini, transform.position.y, posa);
        }
        else
            if (posini == 2.57f)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, 4) + posini, transform.position.y, posa);
        }
        else
            if (posini == 10.02f)
        {
            
            transform.position = new Vector3(Mathf.PingPong(Time.time * 3.5f, 18) + posini, transform.position.y, posa);
        }
        else
            if (posini == 29.28f)
        {
          
            transform.position = new Vector3( posini, transform.position.y, Mathf.PingPong(Time.time * 4f, 15) + posa);
        }
        else
            if (posini == 10.94f)
        {
            
            transform.position = new Vector3(Mathf.PingPong(Time.time * 5f, 7) + posini, transform.position.y, posa);
        }
        else
            if (posini == 12.35f)
        {
            
            transform.position = new Vector3(Mathf.PingPong(Time.time * 3f, 6) + posini, transform.position.y, posa);
        }
        else
            if (posini == 22.43f)
        {

            transform.position = new Vector3(posini, transform.position.y, Mathf.PingPong(Time.time * 2f, 6) + posa);
        }

        // mover Espadas: altura de levantamiento de espada 2.71Y ORIGEN: 1.93Y

    }
}
