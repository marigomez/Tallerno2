using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void ChangeScene(int scenename)
    {
        SceneManager.LoadScene(scenename);
        
    }
   
}
