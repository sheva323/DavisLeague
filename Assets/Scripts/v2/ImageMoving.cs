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
    public int index;

    private void Start()
    {
        index = 0;
    }

    public void Update()
    {
        if (canmove)
        {
            GetCards(index);
        }
    }
    public void GetCards(int i)
    {
        Vector2 CardPositionNew = PreviewPosition[i].transform.position - PlayerCards[i].transform.position;

        if (CardPositionNew.magnitude > accuracy)
        {
            PlayerCards[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
            Debug.Log("mueve");
        }
        else
        {
            if(index == (PlayerCards.Length - 1))
            {
                canmove = false;
            }      
            index++;
        }
    }
    
    public void StarMovement()
    {
        canmove = true;
    }

    IEnumerator WaitForMoving()
    {
        yield return new WaitForSeconds(2f);
        index++;
    }
    
}
