using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoolManager : MonoBehaviour
{

    public GameObject[] cardsPrefab;
    public RectTransform[] cardPosition;
    public GameObject[] cardsRandom;
    
    // Start is called before the first frame update
    void Start()
    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        for (int i = 0; i < 5; i++)
        {
            cardsRandom[i] = Instantiate(cardsPrefab[Random.Range(0, 4)], cardPosition[i].parent);
        }
    }
}
