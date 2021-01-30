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
    float speed ;
    public bool canmove;
    public float accuracy = 0.01f;
    public int index;
    public GameObject CardsPanel;
    public GameObject PoolGamePanel;
    public GameObject DummyTotal;
    public GameObject[] Dummy;
    public AudioSource CardSound;
    public AudioSource SuperStarSound;

    //public ParticleSystem Particles; 


    // Start is called before the first frame update
    void Start()

    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        index = 0;
        for (int i = 0; i < 20; i++)
        {
            cardsRandom[i] = Instantiate(cardsPrefab[Random.Range(0, 6)], cardPosition[i].parent);

        }
    }

    public void Update()
    {
        if (canmove)
        {
            GetCards(index);
        }
    }

    public void SoundCards ()
    {
        if (canmove)
        {
            CardSound.Play();
        }
    }
   
    public void GetCards(int i)
    {
        Vector2 CardPositionNew = PreviewPosition[i].transform.position - Dummy[i].transform.position;
        {
            if (CardPositionNew.magnitude > accuracy)
            {
                if (cardsRandom[i].gameObject.CompareTag("superstar"))
                {
                    speed = 5;                   
                    Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                    Dummy[i].GetComponentInChildren<ParticleSystem>().Play();
                }
                else
                {
                    speed = 20;
                    Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                }                
            }
            else
                {
                    if (index == (Dummy.Length - 1))
                    {
                        canmove = false;
                        CardsPanel.transform.position = PoolGamePanel.transform.position;
                        PoolGamePanel.SetActive(false);
                        DummyTotal.SetActive(false);
                    }
                    index++;
                    CardSound.Play(); 
                        if (index < Dummy.Length-1)
                        {
                            if ((cardsRandom[index].gameObject.CompareTag("superstar")))
                            {
                                SuperStarSound.Play();
                            }
                        }
                        
                }
            }
    }

    public void StarMovement() //function is called with button
    {
        canmove = true;
        if (cardsRandom[0].gameObject.CompareTag("superstar"))
        {
            SuperStarSound.Play();
        }
        CardSound.Play();
    }
}
