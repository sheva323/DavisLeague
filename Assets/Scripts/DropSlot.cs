using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public int Cardvalue;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            Debug.Log("ASIGNÓ CARTA");
            Cardvalue = item.GetComponent<CardValue>().Cardvalue;
            Debug.Log(Cardvalue);
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
