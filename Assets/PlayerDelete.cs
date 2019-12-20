using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDelete : MonoBehaviour
{
    public void DeletePlayPrefs(string name)
    {
        Debug.Log("Borrando Datos");
        PlayerPrefs.DeleteKey(name);
    }
}
