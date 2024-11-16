using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    int actualScene;
    public void Start()
    {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnCambiarDeNivel()
    {
        if (actualScene == 73)
        {
            MMSceneLoadingManager.LoadScene("Nivel2");
        }

        if (actualScene == 74)
        {
            MMSceneLoadingManager.LoadScene("Nivel3.0");
        }
        if (actualScene == 79)
        {
            MMSceneLoadingManager.LoadScene("Boss");
        }

    }
}
