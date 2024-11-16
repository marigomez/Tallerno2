using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditos : MonoBehaviour
{
    public void OnClickCreditos() 
    {
        MMSceneLoadingManager.LoadScene("Creditos");
    }
}
