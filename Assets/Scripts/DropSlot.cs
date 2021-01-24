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
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("ASIGNÓ CARTA");
            Cardvalue = item.GetComponent<CardValue>().Cardvalue;
            PlayerPrefs.SetInt(ValueArray, Cardvalue);
            Debug.Log(Cardvalue);
            Debug.Log(PlayerPrefs.GetInt(ValueArray));
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
