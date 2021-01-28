using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageMoving : MonoBehaviour
{
    public RectTransform[] PreviewPosition;
    public GameObject[] PlayerCards;
    public float accuracy = 0.01f;
    public float speed = 3.0f;
    public bool canmove;

 
    public void Update()
    {
        if (canmove)
        {
            GetCards();
        }
    }
    public void GetCards()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector2 CardPositionNew = PreviewPosition[i].transform.position - PlayerCards[i].transform.position;

            if (CardPositionNew.magnitude > accuracy)
            {
                PlayerCards[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                Debug.Log("mueve");
            }
            
            else
            {
                canmove = false;
            }
        }
    }
    
    public void StarMovement()
    {
        canmove = true;
    }
    
}
