using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int actualScene;
    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }
    [ContextMenu("cambia nivel")]
    public void CambiarDeNivel()
    {
       int nivelactual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nivelactual + 1);
        

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cambio")
        {
            Debug.Log("cambio objeto");
            int nivelactual = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(nivelactual + 1);
        }

           


    }

}


