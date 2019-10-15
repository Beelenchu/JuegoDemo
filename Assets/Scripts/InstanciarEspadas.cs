using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarEspadas : MonoBehaviour
{
    GameObject[] monos;
    public GameObject MonoOriginal;
    // Start is called before the first frame update


    void Start()
    {

        monos = new GameObject[8];

        monos[0] = Instantiate(MonoOriginal, new Vector3(13.29f, 1.93f, 75.73f), Quaternion.identity) as GameObject;
        monos[1] = Instantiate(MonoOriginal, new Vector3(314.16f, 1.93f, 75.73f), Quaternion.identity) as GameObject;
        monos[2] = Instantiate(MonoOriginal, new Vector3(15.05f, 1.93f, 75.73f), Quaternion.identity) as GameObject;
        monos[3] = Instantiate(MonoOriginal, new Vector3(16.1f, 1.93f, 75.73f), Quaternion.identity) as GameObject;
        monos[4] = Instantiate(MonoOriginal, new Vector3(16.86f, 1.93f, 75.73f), Quaternion.identity) as GameObject;

        monos[5] = Instantiate(MonoOriginal, new Vector3(47.27f, 2f, 117.92f), Quaternion.identity) as GameObject;
        monos[6] = Instantiate(MonoOriginal, new Vector3(37f, 2f, 126.2f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-4.7f, 2f, 111.94f), Quaternion.identity) as GameObject;
        

    }

    // Update is called once per frame
    void Update()
    {


    }
}