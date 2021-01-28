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

 
    public void Recall ()
    {
        if (canmove)
        {
            GetCards();
            Debug.Log("CanmoveFunction");
        }
    }

    public void Update()
    {
        if (canmove)
        {
            StarMovement();
        }
    }
    public void GetCards()
    {

        int i = 0;
        if (i<3)
        {
                Vector2 CardPositionNew = PreviewPosition[i].transform.position - PlayerCards[i].transform.position;

                if (CardPositionNew.magnitude > accuracy)
                {
                    PlayerCards[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                    Debug.Log("mueve");
                }
                else
                {
                    Debug.Log("Llego");
                    //canmove = false;
                    i++;
                    Debug.Log(i);
                }
                
        }
        else
        {
            canmove = false;
        }


    }
    
    public void StarMovement()
    {
        Recall();
        canmove = true;
    }
    
}
