using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class LogrosManager : MonoBehaviour
{
    [SerializeField] GameObject[] logros;

    void Start()
    {
        LoadAchivementes();
    }

    public void ResetAchievements()
    {
        MoreMountains.Tools.MMAchievementManager.ResetAllAchievements();

        MMAchievementManager.AchievementsList.ForEach(achievement => achievement.UnlockedStatus = false);

        LoadAchivementes();
    }

    public void LoadAchivementes()
    {
        MMAchievementManager.LoadSavedAchievements();

        MMAchievementManager.AchievementsList.ForEach(achievement =>
        {
            for (int i = 0; i < logros.Length - 1; i++)
            {
                if (achievement.AchievementID == logros[i].name)
                {
                    if (achievement.UnlockedStatus == true)
                    {
                        logros[i].GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1);
                    }
                    else
                    {
                        logros[i].GetComponent<UnityEngine.UI.Image>().color = new Color(0.3f, 0.3f, 0.3f);
                    }
                }
            }
        });
    }
}