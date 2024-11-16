using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class Xacacara : PickableItem
{
    [SerializeField] private GameObject imageGameObject;


    void Awake()
    {
        imageGameObject.SetActive(false);
        
    }

    protected override void Pick(GameObject picker) 
		{
        // we send a new points event for the GameManager to catch (and other classes that may listen to it too)
        imageGameObject.SetActive(true);
        MMAchievementManager.UnlockAchievement("xacarana");
        MMAchievementManager.AchievementsList[0].UnlockedStatus = true;
        MMAchievementManager.SaveAchievements();
    }
}
