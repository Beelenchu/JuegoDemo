using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.name == "Personaje")
        {
            Destroy(obj.gameObject);
        }
    }
}
