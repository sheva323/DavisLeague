using System.Collections;
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
    public GameObject CardsPosition;
    public bool canmove;
    public float accuracy = 0.01f;
    public int index;
    public GameObject CardsPanel;
    public GameObject PoolGamePanel;
    public GameObject DummyTotal;
    public GameObject[] Dummy;
    public AudioSource CardSound;
    public AudioSource SuperStarSound;
    public AudioSource AngelSound;
    public ParticleSystem ParticlesChange;
    public Animator SuperStarAnimation;
    public GameObject [] Videos;
    public GameObject[] RawImages;
    public int VideoRandom;
    public Transform DummyPosition;
    public GameObject PreviewPositionGroup;
    private int secondSuperstar;
    private GameObject[] gamePosition;
    Vector3 startPosition = new Vector3(4.3f, -1.52f, 1.0f);
    private GameObject CardsGame;
    private void Awake()
    {
        //PlayerPrefs.SetInt("BattleNumber", 0); //Just for testing

        gamePosition = GameObject.FindGameObjectsWithTag("gameposition");
        if (gamePosition.Length > 1)
        {
            Destroy(gamePosition[1]);
        }
        PlayerPrefs.SetInt("BattleNumber", PlayerPrefs.GetInt("BattleNumber") + 1);
        PlayerPrefs.SetInt("SuperStarAnimation", 0);
        for (int i = 0; i < Dummy.Length; i++)
        {
            Dummy[i].transform.Translate(DummyPosition.position);
        }
        secondSuperstar = (Random.Range(0, 2)); 
    }
    private void RandomChange()
    {
        VideoRandom = Random.Range(0, 5);
    }
    void Start()
    //This script creates 20 random cards Between AllStar, Superstar, Roleplayer, Bencharmer. Creates a copy of 4 Prefabs cards
    //Storage them in PoolGame (Scene A1)
    {
        CardsGame = GameObject.FindGameObjectWithTag("gameposition");
        CardsGame.transform.position = startPosition;
        DontDestroyOnLoad(PreviewPositionGroup);
        VideoRandom = Random.Range(0, 5);
        Invoke("RandomChange", 9f);
        index = 0;
        if (PlayerPrefs.GetInt("BattleNumber") == 1)
        {
            PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle1", 0); //Restart Number of Battles won
            PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle1", 0);//Restart Number of Battles won
            PlayerPrefs.SetInt("ScorePlayer1", 0);//Restart Scoreplayer
            PlayerPrefs.SetInt("ScoreCPU", 0);//Restart Score CPU

        }
        if (PlayerPrefs.GetInt("BattleNumber") > 1)
        {
            GetYourHand.gameObject.SetActive(false);
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
                DummyTotal.SetActive(false);
            }
            if (PlayerPrefs.GetInt("SuperStarAnimation") == 1)
            {
                canmove = false;
            }
        }
        if (canmove)
        {
            GetCards(index);
        }
        print(PlayerPrefs.GetInt("BattleNumber"));
    }
    private void ShowCards()
    {
        for (int i=0; i< 9; i++)
        {
            PreviewPosition[i].GetChild(Random.Range(0, PreviewPosition[i].childCount)).gameObject.SetActive(true);
        }
        PreviewPosition[9].GetChild(secondSuperstar).gameObject.SetActive(true);
        for (int i = 10; i < PreviewPosition.Length; i++)
        {
            PreviewPosition[i].GetChild(Random.Range(0, PreviewPosition[i].childCount)).gameObject.SetActive(true);
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

        if (CardPositionNew.magnitude > accuracy)
        {
            if (i == 4)
            {
                float speed = 4;
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Play();
                Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                RawImages[VideoRandom].SetActive(true);
                Videos[VideoRandom].GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            }
            else if (i == 9 && secondSuperstar == 1)
            {
                float speed = 4;
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Play();
                Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
                RawImages[VideoRandom].SetActive(true);
                Videos[VideoRandom].GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            }
            else
            {
                float speed = 20;
                Dummy[i].transform.Translate(CardPositionNew * speed * Time.deltaTime);
            }
        }
        else
        {
            if (index == (Dummy.Length - 1))
            {
                canmove = false;
            }
            if (i == 4)
            {
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Stop();
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[0].Play();
            }
            if (i == 9 && secondSuperstar == 1)
            {
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[1].Stop();
                Dummy[i].GetComponentsInChildren<ParticleSystem>()[0].Play();
            }
            index++;
            CardSound.Play();
            if (index == Dummy.Length)
            {
                ParticlesChange.Play();
                ShowCards();
            }
            if (i == 4)
            {
                SuperStarAnimation.SetBool("ActivateSuperStarAnimation", true);
                AngelSound.Play();
            }
            if (i == 9 && secondSuperstar == 1)
            {
                SuperStarAnimation.SetBool("ActivateSuperStarAnimation", true);
                AngelSound.Play();
            }
        }
    }

    public void StarMovement() //function is called with button
    {
        canmove = true;
        CardSound.Play();
    }
}
