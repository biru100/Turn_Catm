using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerUI : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private Transform Stick;

    public void OnDrag(PointerEventData data)
    {
        Stick.position = data.position;
    }
}
