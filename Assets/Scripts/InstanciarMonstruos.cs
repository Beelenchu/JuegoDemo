using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarMonstruos : MonoBehaviour
{
    GameObject[] monos;
    public GameObject MonoOriginal;
    // Start is called before the first frame update


    void Start()
    {

        monos = new GameObject[8];

        monos[0] = Instantiate(MonoOriginal, new Vector3(27.64f, 2f, 95.84f), Quaternion.identity) as GameObject;
        monos[1] = Instantiate(MonoOriginal, new Vector3(30.13f, 2f, 93.16f), Quaternion.identity) as GameObject;
        monos[2] = Instantiate(MonoOriginal, new Vector3(48f, 2f, 110.37f), Quaternion.identity) as GameObject;
        monos[3] = Instantiate(MonoOriginal, new Vector3(42.12f, 2f, 93.04f), Quaternion.identity) as GameObject;
        monos[4] = Instantiate(MonoOriginal, new Vector3(44.08f, 2f, 96.55f), Quaternion.identity) as GameObject;
        monos[5] = Instantiate(MonoOriginal, new Vector3(47.27f, 2f, 117.92f), Quaternion.identity) as GameObject;
        monos[6] = Instantiate(MonoOriginal, new Vector3(37f, 2f, 126.2f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-4.7f, 2f, 111.94f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-20.5f, 2f, 128f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-18.7f, 2f, 139.7f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(7.9f, 2f, 151.2f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-3.3f, 2f, 163.4f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-3.2f, 2f, 187f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(20.4f, 2f, 172.9f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(25.7f, 2f, 149.8f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(48.1f, 2f, 149.8f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(30.8f, 2f, 177.2f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(14.6f, 2f, 140.7f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(37.7f, 2f, 137f), Quaternion.identity) as GameObject;
        monos[7] = Instantiate(MonoOriginal, new Vector3(-25.6f, 2f, 176f), Quaternion.identity) as GameObject;

    }

    // Update is called once per frame
    void Update()
    {


    }
}
