﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoolManager : MonoBehaviour
{
    public Button GetYourHand;
    public Button StartButton;
    public GameObject[] cardsPrefab;
    public RectTransform[] cardPosition;
    public GameObject[] cardsRandom;
    public RectTransform[] PreviewPosition;
    float speed;
    public bool canmove;
    public float accuracy = 0.01f;
    public int index;
    public GameObject CardsPanel;
    public GameObject PoolGamePanel;
    public GameObject DummyTotal;
    public GameObject[] Dummy;
    public AudioSource CardSound;
    public AudioSource SuperStarSound;
    public ParticleSystem ParticlesChange;
    private GameObject PoolGame;
    Vector3 PoolGameVector;
    public Animator SuperStarAnimation;

    // Start is called before the first frame update
    private void Awake()
    {
        PoolGame = GameObject.FindGameObjectWithTag("PoolGame");
        PoolGame.SetActive(true);
        PlayerPrefs.SetInt("SuperStarAnimation", 0);
    }
    
    void Start()
    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        index = 0;

        cardsRandom[0] = Instantiate(cardsPrefab[Random.Range(2, 6)], cardPosition[0].parent); 
        cardsRandom[1] = Instantiate(cardsPrefab[Random.Range(2, 6)], cardPosition[1].parent);
        cardsRandom[2] = Instantiate(cardsPrefab[Random.Range(2, 6)], cardPosition[2].parent);
        cardsRandom[3] = Instantiate(cardsPrefab[3], cardPosition[3].parent);
        cardsRandom[4] = Instantiate(cardsPrefab[1], cardPosition[4].parent);
        cardsRandom[5] = Instantiate(cardsPrefab[0], cardPosition[5].parent);
        cardsRandom[6] = Instantiate(cardsPrefab[0], cardPosition[6].parent);
        cardsRandom[7] = Instantiate(cardsPrefab[0], cardPosition[7].parent);
        cardsRandom[8] = Instantiate(cardsPrefab[3], cardPosition[8].parent);
        cardsRandom[9] = Instantiate(cardsPrefab[Random.Range(0, 2)], cardPosition[9].parent);
        cardsRandom[10] = Instantiate(cardsPrefab[Random.Range(3, 6)], cardPosition[10].parent);
        cardsRandom[11] = Instantiate(cardsPrefab[Random.Range(3, 6)], cardPosition[11].parent);
        cardsRandom[12] = Instantiate(cardsPrefab[Random.Range(3, 6)], cardPosition[12].parent);
        cardsRandom[13] = Instantiate(cardsPrefab[Random.Range(3, 6)], cardPosition[13].parent);
        cardsRandom[14] = Instantiate(cardsPrefab[Random.Range(3, 6)], cardPosition[14].parent);
        cardsRandom[15] = Instantiate(cardsPrefab[2], cardPosition[15].parent);
        cardsRandom[16] = Instantiate(cardsPrefab[2], cardPosition[16].parent);
        cardsRandom[17] = Instantiate(cardsPrefab[2], cardPosition[17].parent);
        cardsRandom[18] = Instantiate(cardsPrefab[2], cardPosition[18].parent);
        cardsRandom[19] = Instantiate(cardsPrefab[2], cardPosition[19].parent);

        BattleCounter();
        if (PlayerPrefs.GetInt("BattleNumber") == 1)
        {
            PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle1", 0); //Restart Number of Battles won
            PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle1", 0);//Restart Number of Battles won
            PlayerPrefs.SetInt("ScorePlayer1", 0);//Restart Scoreplayer
            PlayerPrefs.SetInt("ScoreCPU", 0);//Restart Score CPU

        }
        if (PlayerPrefs.GetInt("BattleNumber") == 2|| PlayerPrefs.GetInt("BattleNumber") == 3 
            || PlayerPrefs.GetInt("BattleNumber") == 4 || PlayerPrefs.GetInt("BattleNumber") == 5)
        {
            PoolGame = GameObject.FindGameObjectWithTag("PoolGame");
            PoolGameVector = new Vector3(4.8f, -1.8f, 1.0f);
            PoolGame.transform.position = PoolGameVector;
        }
    }

    public void Update()
    {
        if (index != (Dummy.Length))
        {
            if (PlayerPrefs.GetInt("SuperStarAnimation") == 2)
            {
                SuperStarAnimation.SetBool("ActivateSuperStarAnimation", false);
                canmove = true;
                if (index == (Dummy.Length))
                {
                    canmove = false;
                }
            }
            if (PlayerPrefs.GetInt("SuperStarAnimation") == 1)
            {
                canmove = false;

            }
        }
        if (index == (Dummy.Length))
        {
            if (PlayerPrefs.GetInt("SuperStarAnimation") == 2)
            {
                SuperStarAnimation.SetBool("ActivateSuperStarAnimation", false);
                canmove = false;
                CardsPanel.transform.position = PoolGamePanel.transform.position;
                //PoolGamePanel.SetActive(false);
                DummyTotal.SetActive(false);
            }
            if (PlayerPrefs.GetInt("SuperStarAnimation") == 1)
            {
                canmove = false;
                CardsPanel.transform.position = PoolGamePanel.transform.position;
            }
        }
        if (canmove)
        {
            GetCards(index);
        }
    }

    public void SoundCards()
    {
        if (canmove)
        {
            CardSound.Play();
        }
    }

    public void GetCards(int i)
    {
        if (index == (Dummy.Length))
        {
            canmove = false;
        }
        GetYourHand.gameObject.SetActive(false);
        Vector2 CardPositionNew = PreviewPosition[i].transform.position - Dummy[i].transform.position;
        {
            if (CardPositionNew.magnitude > accuracy)
            {
                if (cardsRandom[i].gameObject.CompareTag("superstar"))
                {
                    speed = 4;
                    Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Play();
                    Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);

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
                    if (cardsRandom[index].gameObject.CompareTag("superstar"))
                    {
                        Dummy[index].GetComponentsInChildren<ParticleSystem>()[0].Play();
                    }
                    canmove = false;
                }
                if (cardsRandom[i].gameObject.CompareTag("superstar"))
                {
                    Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Stop();
                    Dummy[i].GetComponentsInChildren<ParticleSystem>()[0].Play();
                }
                index++;
                CardSound.Play();
                if (index == Dummy.Length)
                {
                    ParticlesChange.Play();
                }
                else if (index <= Dummy.Length - 1)
                {
                    if ((cardsRandom[index].gameObject.CompareTag("superstar")))
                    {
                        SuperStarSound.Play();
                    }
                }
                if (cardsRandom[i].gameObject.CompareTag("superstar"))
                {
                    SuperStarAnimation.SetBool("ActivateSuperStarAnimation", true);
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

    public void BattleCounter()
    {
        if (PoolGame.transform.childCount == 40)
        {
            PlayerPrefs.SetInt("BattleNumber", 1);
            Debug.Log("Battle1");
        }
        if (PoolGame.transform.childCount == 35)
        {
            PlayerPrefs.SetInt("BattleNumber", 2);
            Debug.Log("Battle2");
            GetYourHand.gameObject.SetActive(false);
        }
        if (PoolGame.transform.childCount == 30)
        {
            PlayerPrefs.SetInt("BattleNumber", 3);
            Debug.Log("Battle3");
            GetYourHand.gameObject.SetActive(false);
        }
        if (PoolGame.transform.childCount == 25)
        {
            PlayerPrefs.SetInt("BattleNumber", 4);
            Debug.Log("Battle4");
            GetYourHand.gameObject.SetActive(false);
        }
    }
}
