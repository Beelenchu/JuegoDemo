using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySonido : MonoBehaviour
{
    public AudioClip sonidoArma;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audio.clip = sonidoArma;
            audio.Play();
        }
    }
}
