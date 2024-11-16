using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class InmunidadEstrella : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        MMEventManager.TriggerEvent(new PickableItemEvent(this));
    }
}
