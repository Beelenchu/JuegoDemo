using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    float posini;
    float posa;
    float posy;
    public GameObject obj;
    public Text scoreText;
    int score;
    void Start()
    {
        posini = transform.position.x;
        posa = transform.position.z;
        posy = transform.position.y;

        score = 0;
        UpdateScore();
        if (PlayerPrefs.HasKey("dato1"))
        {
            int info = PlayerPrefs.GetInt("dato1");
            Debug.Log("Guarda 22: " + info);
            scoreText.text = "Oro: " + info + "/" + "3000";
            
        }
    }

    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = "Oro: " + score + "/" + "3000";
        
        if (score == 3000)
        {
            Destroy(obj.gameObject);
        }

        //scoreText.text = "Puntaje: " + info;
    }
    public void AddScore(int valor)
    {
        score += valor;
        UpdateScore();
        Guardar(score);
    }



    void Guardar(int score)
    {
        PlayerPrefs.SetInt("dato1", score);
        Debug.Log("GUarda");


        if (PlayerPrefs.HasKey("dato1"))
        {
            int info = PlayerPrefs.GetInt("dato1");
            Debug.Log("Guardaddo: " + info);
        }

    }

}

// Start is called before the first frame update
