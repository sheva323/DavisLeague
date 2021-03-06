﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreAnimationManager : MonoBehaviour
{
    public Animator CPUWinsAnimator;
    public Animator Player1WinsAnimator;
    public GameObject CardControl;
    public TextMeshProUGUI ScorePlayer1;
    public TextMeshProUGUI ScoreCPU;
    public Text Player1Wins;
    public Text Player1Loses;
    public Text CPUWins;
    public Text CPULoses;
    public AudioSource Crowd;
    public AudioSource Aww;
    /*private void Awake() // Solo para pruebas
    {
        PlayerPrefs.SetInt("BattleNumber", 4);
        PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 2);
        PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 2);
    }*/
    void Start()
    {
        ScoreManager();
        Destroy(CardControl, 3.7f);
        if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
        {
            Player1WinsAnimator.SetBool("Player1Wins", true);
            Player1Wins.gameObject.SetActive(true);
            CPULoses.gameObject.SetActive(true);
            Crowd.Play();
        }
        if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
        {
            CPUWinsAnimator.SetBool("CPUWins", true);
            CPUWins.gameObject.SetActive(true);
            Player1Loses.gameObject.SetActive(true);
            Aww.Play();
        }
        if (PlayerPrefs.GetInt("ScorePlayer1") == PlayerPrefs.GetInt("ScoreCPU"))
        {
            CPUWinsAnimator.SetBool("CPUWins", true);
            CPUWins.gameObject.SetActive(true);
            Player1WinsAnimator.SetBool("Player1Wins", true);
            Player1Wins.gameObject.SetActive(true);
            Crowd.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!CardControl)
        {
            if (PlayerPrefs.GetInt("BattleNumber") < 4)
            {
                SceneManager.LoadScene(2); //A1. Main Screen
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 4)
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") > PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"))
                {
                    SceneManager.LoadScene(5); //winner
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") < PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"))
                {
                    SceneManager.LoadScene(6); //Looser
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") == PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4")) //Tie
                {
                    SceneManager.LoadScene(7); //Break Tie
                }
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 5)
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle5") > PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle5"))
                {
                    SceneManager.LoadScene(5); //winner
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle5") < PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle5"))
                {
                    SceneManager.LoadScene(6); //Looser
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle5") == PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle5")) //Tie
                {
                    PlayerPrefs.SetInt("BattleNumber", 5);
                    SceneManager.LoadScene(7); //Break Tie
                }
            }
        }
    }

    void ScoreManager ()
    {
        print(PlayerPrefs.GetInt("BattleNumber"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle5"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle5"));

        if (PlayerPrefs.GetInt("BattleNumber") == 1)
        {
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1")==1)
            {
                ScorePlayer1.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
            {
                ScoreCPU.text = "01";
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 2)
        {
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
            {
                ScorePlayer1.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
            {
                ScorePlayer1.text = "02";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
            {
                ScoreCPU.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
            {
                ScoreCPU.text = "02";
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 3)
        {
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 1)
            {
                ScorePlayer1.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 2)
            {
                ScorePlayer1.text = "02";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 3)
            {
                ScorePlayer1.text = "03";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 1)
            {
                ScoreCPU.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 2)
            {
                ScoreCPU.text = "02";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 3)
            {
                ScoreCPU.text = "03";
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 4)
        {
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") == 1)
            {
                ScorePlayer1.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") == 2)
            {
                ScorePlayer1.text = "02";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") == 3)
            {
                ScorePlayer1.text = "03";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4") == 4)
            {
                ScorePlayer1.text = "04";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4") == 1)
            {
                ScoreCPU.text = "01";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4") == 2)
            {
                ScoreCPU.text = "02";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4") == 3)
            {
                ScoreCPU.text = "03";
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4") == 4)
            {
                ScoreCPU.text = "04";
            }

        }
        if (PlayerPrefs.GetInt("BattleNumber") == 5)
        {
            ScorePlayer1.text = PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle5").ToString();
            ScoreCPU.text = PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle5").ToString();
        }
    }
}
