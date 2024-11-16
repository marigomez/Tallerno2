using MoreMountains.CorgiEngine;
using UnityEngine;

public class Opendoor : PickableItem
{
    [SerializeField] private GameObject objectToDeactivate;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("mymelody");
            objectToDeactivate.SetActive(false);
        }
        Debug.Log("hellokitty");
    }
    protected override void Pick(GameObject picker) 
		{
        // we send a new points event for the GameManager to catch (and other classes that may listen to it too)
        objectToDeactivate.SetActive(false);
    }
}