using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreeper : MonoBehaviour
{
    public float velocidad;
    public float distancia;
    
    
    float posini;
    float posa;
   // float posRandom;
    // Start is called before the first frame update
    void Start()
    {
        posini = transform.position.x;
        posa = transform.position.z;
        /*
       
        
        
        monos = GameObject.FindGameObjectsWithTag("Creeper");

        for (int i = 0; i < monos.Length; i++)
        {
              posRandom = Random.Range(-95f, 120f);
             
          //  Debug.Log("Player Number " + i + " nombre: " + monos[i].name + " en posicion" + monos[i].transform.position.x);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (posini == -13.46f)
        {
            Debug.Log(" y posIni -> " + posini);
            transform.position = new Vector3(Mathf.PingPong(Time.time * 3, 15) + posini, transform.position.y, posa);
        }
        else
            if (posini == 2.57f)
        {
            Debug.Log(" y posIni -> " + posini);
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, 4) + posini, transform.position.y, posa);
        }
        else
            if (posini == 10.02f)
        {
            Debug.Log(" y posIni -> " + posini);
            transform.position = new Vector3(Mathf.PingPong(Time.time * 3.5f, 18) + posini, transform.position.y, posa);
        }
        else
            if (posini == 29.28f)
        {
            Debug.Log(" y posIni -> " + posini);
            transform.position = new Vector3( posini, transform.position.y, Mathf.PingPong(Time.time * 3.5f, 15) + posa);
        }
        else
            if (posini == 10.94f)
        {
            Debug.Log(" y posIni -> " + posini);
            transform.position = new Vector3(Mathf.PingPong(Time.time * 5f, 7) + posini, transform.position.y, posa);
        }
        /*
             Debug.Log( " y posIni -> " + posini);
             transform.position = new Vector3(Mathf.PingPong(Time.time * velocidad, distancia) + posini, transform.position.y, posa);

     */

    }
}
