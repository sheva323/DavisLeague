using System.Collections;
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
    void Start()
    {
        ScoreManager();
        Destroy(CardControl, 3.7f);
        if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
        {
            Player1WinsAnimator.SetBool("Player1Wins", true);
            Player1Wins.gameObject.SetActive(true);
            CPULoses.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
        {
            CPUWinsAnimator.SetBool("CPUWins", true);
            CPUWins.gameObject.SetActive(true);
            Player1Loses.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!CardControl)
        {
            if (PlayerPrefs.GetInt("BattleNumber") != 4)
            {
                SceneManager.LoadScene(2); //A1. Main Screen
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 4)
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4")> PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"))
                {
                    SceneManager.LoadScene(5); //winner
                }
                else
                {
                    SceneManager.LoadScene(6); //Looser
                }
            }
        }
    }

    void ScoreManager ()
    {
        print(PlayerPrefs.GetInt("BattleNumber"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3"));
        print(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4"));
        print(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"));

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
    }
}
