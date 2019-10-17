using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciarbala : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject cubebala = Instantiate(obj, transform.position, transform.rotation) as GameObject;

            //Destroy(cubebala, 5f);

            cubebala.GetComponent<Rigidbody>().velocity = transform.right * 50;
        }
    }
}
