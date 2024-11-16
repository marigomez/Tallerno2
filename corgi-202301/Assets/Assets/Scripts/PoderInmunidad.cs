using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class PoderInmunidad : MonoBehaviour, MMEventListener<PickableItemEvent>
{
 [SerializeField] 
    private float timepo_inmunidad = 3;
    private GameObject _fadeObject;
    private Health salud_personaje;

    [Header("inmunidad")]
    [MMInspectorButton("Control inmunidad")]
    private bool control_inmunidad_button;

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        if(e.PickedItem.name == "RetroStar")
        {
            ControlInmunidad();
        }
    }

    public Health getHealth()
    {
        _fadeObject = LevelManager.Instance.Players[0].gameObject;

        return _fadeObject.GetComponent<Health>();
    }

    public void ControlInmunidad()
    {
        salud_personaje = getHealth();
        salud_personaje.Invulnerable = true;
        StartCoroutine(DesactivarInmunidad());
    }

    public IEnumerator DesactivarInmunidad()
    {
        yield return new WaitForSeconds(timepo_inmunidad);

        salud_personaje.Invulnerable = false;
    }
}
