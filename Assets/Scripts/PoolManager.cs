using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoolManager : MonoBehaviour
{

    public GameObject[] cardsPrefab;
    public RectTransform[] cardPosition;
    public GameObject[] cardsRandom;
    public RectTransform [] PreviewPosition;
    public float speed = 10.0f;
    public bool canmove;
    public float accuracy = 0.01f;
    int i = 0;
    // Start is called before the first frame update
    void Start()

    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        for (int i = 0; i < 20; i++)
        {
            cardsRandom[i] = Instantiate(cardsPrefab[Random.Range(0, 4)], cardPosition[i].parent);
        }
    }

    public void Update()
    {
        if (canmove)
        {
            for (int j =0; j<4; j++)
            GetCards();
            if (!canmove)
            {
                i++;
            }

        }
    }
   
    public void GetCards()
    { 
        Vector2 CardPositionNew = PreviewPosition[i].transform.position - cardsRandom[i].transform.position;
            {
                if (CardPositionNew.magnitude > accuracy)
                {
                    cardsRandom[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                    PlayerPrefs.SetInt("canmove", 1);
                }
                else
                {
                    canmove = false;
                    PlayerPrefs.SetInt("canmove", 0);
                }
            }
    }

    public void StarMovement()
    {
        canmove = true;
    }
}
