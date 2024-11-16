using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CkeckSCene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;

        if (actualScene == 72)
        {
            MMAchievementManager.UnlockAchievement("menu");
            MMAchievementManager.AchievementsList[1].UnlockedStatus = true;
            SaveAchivs();
        }
       
    }

    public static void SaveAchivs()
    {
        MMAchievementManager.SaveAchievements();
    }
}
