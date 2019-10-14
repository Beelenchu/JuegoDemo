using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarMonos : MonoBehaviour
{
    GameObject[] monos;
    public GameObject MonoOriginal;
    // Start is called before the first frame update
  

    void Start()
    {
        
        monos = new GameObject[5];
        
            monos[0] = Instantiate(MonoOriginal, new Vector3(-13.46f, 1.8f, 39.01f), Quaternion.identity) as GameObject;
        monos[0].transform.rotation = new Quaternion(0, 270, 270,0);

          monos[1] = Instantiate(MonoOriginal, new Vector3(2.57f, 1.8f, 45.72f), Quaternion.identity) as GameObject;
        monos[1].transform.rotation = new Quaternion(0, 270, 270, 0);

        monos[2] = Instantiate(MonoOriginal, new Vector3(10.02f, 1.8f, 54.29f), Quaternion.identity) as GameObject;
        monos[2].transform.rotation = new Quaternion(0, 270, 270, 0);

        monos[3] = Instantiate(MonoOriginal, new Vector3(29.28f, 1.8f, 55.24f), Quaternion.identity) as GameObject;
        monos[3].transform.rotation = new Quaternion(0, 270, 270, 0);

        monos[4] = Instantiate(MonoOriginal, new Vector3(10.94f, 1.8f, 77.26f), Quaternion.identity) as GameObject;
        monos[4].transform.rotation = new Quaternion(0, 270, 270, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
