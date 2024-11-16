using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : MonoBehaviour
{
    public void OnClickInstrucciones() 
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }
}
