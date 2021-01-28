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
    public int index;
    // Start is called before the first frame update
    void Start()

    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        index = 0;
        for (int i = 0; i < 20; i++)
        {
            cardsRandom[i] = Instantiate(cardsPrefab[Random.Range(0, 4)], cardPosition[i].parent);
        }
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
        Vector2 CardPositionNew = PreviewPosition[i].transform.position - cardsRandom[i].transform.position;
            {
                if (CardPositionNew.magnitude > accuracy)
                {
                    cardsRandom[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                    PlayerPrefs.SetInt("canmove", 1);
                }
                else
                {
                    if (index == (cardsRandom.Length - 1))
                    {
                        canmove = false;
                    }
                    index++;
                    PlayerPrefs.SetInt("canmove", 0);
                }
            }
    }

    public void StarMovement()
    {
        canmove = true;
    }
}
