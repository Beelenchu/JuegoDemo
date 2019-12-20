using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemGameObjectFilter : MonoBehaviour
{
    // Start is called before the first frame update
    public void DeletePlayPrefs()
    {
        Debug.Log("Borrando Datos");
        PlayerPrefs.DeleteKey("Guardaddo");
    }
}
