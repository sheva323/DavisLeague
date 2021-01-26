using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public int Cardvalue;
    public int SlotIndex;
    public string ValueArray;
    // Start is called before the first frame update

    public void OnDrop(PointerEventData eventData)
    { 
        //If item exists when random draggable objects are created (20 in total) It is asigned the random CARDVALUE created in Script "CardValue" 
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Cardvalue = item.GetComponent<CardValue>().Cardvalue;
            PlayerPrefs.SetInt(ValueArray, Cardvalue); //Save the value to Player preferences with the name of "SlotIndex" asssigned to each of the 5 Slots in ...
            //... scene A1 upper part when 5 cards are dragged to the 5 slots
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

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Colision");
    }
}
