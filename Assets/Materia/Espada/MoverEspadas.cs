using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEspadas : MonoBehaviour
{
    // Start is called before the first frame update
    float posini;
    float posa;
    float posy;
   
   
    
    void Start()
    {
        posini = transform.position.x;
        posa = transform.position.z;
        posy = transform.position.y;


    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "espada1")
        {
           
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 1f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada2")
        {
            
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 2f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada3")
        {
           
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 1f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada4")
        {
           
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 2f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada5")
        {
            
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 1f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada6")
        {
            
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 2f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada7")
        {
           
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 1f, 1) + posy, posa);
        }
        else
            if (gameObject.name == "espada8")
        {
            
            transform.position = new Vector3(posini, Mathf.PingPong(Time.time * 2f, 1) + posy, posa);
        }
       

    }
}
