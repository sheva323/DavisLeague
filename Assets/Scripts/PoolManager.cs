using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoolManager : MonoBehaviour
{

    public GameObject[] cardsPrefab;
    public GameObject poolPrevious;
    public GameObject poolGame;
    public RectTransform[] cardPosition;
    public GameObject[] cardsRandom;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            cardsRandom[i] = Instantiate(cardsPrefab[Random.Range(0, 4)], cardPosition[i].parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
