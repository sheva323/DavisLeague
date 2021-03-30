using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public string Tag;
    public string CardTag;
    public int Cardvalue;
    public int SlotIndex;
    public string ValueArray;


    private void Start()
    {
        item = null;
    }

    public void OnDrop(PointerEventData eventData)
    { 
        //If item exists when random draggable objects are created (20 in total) It is asigned the random CARDVALUE created in Script "CardValue" 
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Cardvalue = item.GetComponent<CardValue>().Cardvalue;
            CardTag = item.GetComponent<CardValue>().tagCard;
            PlayerPrefs.SetInt(ValueArray, Cardvalue); //Save the value to Player preferences with the name of "SlotIndex" asssigned to each of the 5 Slots in ...
            //... scene A1 upper part when 5 cards are dragged to the 5 slots
            PlayerPrefs.SetString(Tag, CardTag);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}
