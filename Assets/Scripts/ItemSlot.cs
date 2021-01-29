using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {

        }

    }
}
