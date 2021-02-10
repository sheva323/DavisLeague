using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;
    //public GameObject Image;
    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;
    private RectTransform rectTransform;
       //Dragable object is marked with tag "DragParent"
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        {
            itemDragging = gameObject;
            startPosition = transform.position;
            startParent = transform.parent;
            transform.SetParent(dragParent);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 
        itemDragging.transform.position.z ));
    }

    public void OnEndDrag(PointerEventData eventData) //Change position of draggable object
    { 
        itemDragging = null;
            
            if (transform.parent == dragParent)
            {
                transform.position = startPosition;
                transform.SetParent(startParent);
            }
    }
}
