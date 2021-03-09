using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ChargeCardValues : MonoBehaviour
{
    public GameObject[] OriginalCards;
    public GameObject PanePlayer1;
    public RectTransform[] Slots;
    public GameObject[] CopiedCards;
    public TextMeshProUGUI ScoreSlot0;
    public TextMeshProUGUI ScoreSlot1;
    public TextMeshProUGUI ScoreSlot2;
    public TextMeshProUGUI ScoreSlot3;
    public TextMeshProUGUI ScoreSlot4;
    public TextMeshProUGUI ScoreSlot5;
    public TextMeshProUGUI ScoreSlot6;
    public TextMeshProUGUI ScoreSlot7;
    public TextMeshProUGUI ScoreSlot8;
    public TextMeshProUGUI ScoreSlot9;
    public TextMeshProUGUI TextScoreSlot0;
    public TextMeshProUGUI TextScoreSlot1;
    public TextMeshProUGUI TextScoreSlot2;
    public TextMeshProUGUI TextScoreSlot3;
    public TextMeshProUGUI TextScoreSlot4;
    public TextMeshProUGUI TextScoreSlot5;
    public TextMeshProUGUI TextScoreSlot6;
    public TextMeshProUGUI TextScoreSlot7;
    public TextMeshProUGUI TextScoreSlot8;
    public TextMeshProUGUI TextScoreSlot9;
    public TextMeshProUGUI PlayerScore;
    public TextMeshProUGUI CPUScore;
    public GameObject PoolGamePosition;
    public GameObject Sevens0;
    public GameObject Sevens1;
    public GameObject Sevens2;
    public GameObject Sevens3;
    public GameObject Sevens4;
    public GameObject Sevens5;
    public GameObject Sevens6;
    public GameObject Sevens7;
    public GameObject Sevens8;
    public GameObject Sevens9;
    public GameObject SlotsPlayer;
    public GameObject SlotsCPU;
    public GameObject Round1End;
    public GameObject Round2End;
    public GameObject Round3End;
    public GameObject Round4End;
    public GameObject StaticBall1Player1;
    public GameObject StaticBall2Player1;
    public GameObject StaticBall3Player1;
    public GameObject StaticBall1CPU;
    public GameObject StaticBall2CPU;
    public GameObject StaticBall3CPU;
    public Animator Ball1Player1Animator;
    public Animator Ball2Player1Animator;
    public Animator Ball3Player1Animator;
    public Animator Ball4Player1Animator;
    public Animator Ball1CPUAminator;
    public Animator Ball2CPUAminator;
    public Animator Ball3CPUAminator;
    public Animator Ball4CPUAminator;
    GameObject PoolGame;
    public AudioSource SlotMachine;
    public AudioSource Sevens;
    public AudioSource SlotEnd;
    public AudioSource Crow;
    public AudioSource Aww;
    public int PointsSlot0;
    public int PointsSlot1;
    public int PointsSlot2;
    public int PointsSlot3;
    public int PointsSlot4;



    private void Awake()
    {
        // Slot0
        if (PlayerPrefs.GetString("Tag0") == "superstar")
        {
            int i = Random.Range(0, 3);
            if (i== 0)
            {
                PointsSlot0 = Random.Range(10, 16);
            }
            else
            {
                PointsSlot0 = Random.Range(25, 36);
            }
            if (PointsSlot0 >= 25)
            {
                Invoke("PlayCrowSound", 2f);
            }
            else
            {
                Invoke("PlayAwwSound", 2f);
            }
        }
        if (PlayerPrefs.GetString("Tag0") == "allstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot0 = Random.Range(7, 11);
            }
            else
            {
                PointsSlot0 = Random.Range(15, 28);
            }
            if (PointsSlot0 >= 15)
            {
                Invoke("PlayCrowSound", 2f);
            }
            else
            {
                Invoke("PlayAwwSound", 2f);
            }
        }
        if (PlayerPrefs.GetString("Tag0") == "roleplayer")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot0 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot0 = Random.Range(7, 16);
            }
            if (PointsSlot0 >= 7)
            {
                Invoke("PlayCrowSound", 2f);
            }
            else
            {
                Invoke("PlayAwwSound", 2f);
            }
        }
        if (PlayerPrefs.GetString("Tag0") == "roleplayer2")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot0 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot0 = Random.Range(7, 16);
            }
            if (PointsSlot0 >= 7)
            {
                Invoke("PlayCrowSound", 2f);
            }
            else
            {
                Invoke("PlayAwwSound", 2f);
            }
        }
        if (PlayerPrefs.GetString("Tag0") == "roleplayer3")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot0 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot0 = Random.Range(7, 16);
            }
            if (PointsSlot0 >= 7)
            {
                Invoke("PlayCrowSound", 2f);
            }
            else
            {
                Invoke("PlayAwwSound", 2f);
            }
        }
        if (PlayerPrefs.GetString("Tag0") == "benchwarmer")
        {
            PointsSlot0 = Random.Range(2, 7);
            Invoke("PlayAwwSound", 2f);
        }
        //Slot1
        if (PlayerPrefs.GetString("Tag1") == "superstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot1 = Random.Range(10, 16);
            }
            else
            {
                PointsSlot1 = Random.Range(25, 36);
            }
            if (PointsSlot1 >= 25)
            {
                Invoke("PlayCrowSound", 4f);
            }
            else
            {
                Invoke("PlayAwwSound", 4f);
            }
        }
        if (PlayerPrefs.GetString("Tag1") == "allstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot1 = Random.Range(7, 11);
            }
            else
            {
                PointsSlot1 = Random.Range(15, 28);
            }
            if (PointsSlot1 >= 15)
            {
                Invoke("PlayCrowSound", 4f);
            }
            else
            {
                Invoke("PlayAwwSound", 4f);
            }
        }
        if (PlayerPrefs.GetString("Tag1") == "roleplayer")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot1 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot1 = Random.Range(7, 16);
            }
            if (PointsSlot1 >= 7)
            {
                Invoke("PlayCrowSound", 4f);
            }
            else
            {
                Invoke("PlayAwwSound", 4f);
            }
        }
        if (PlayerPrefs.GetString("Tag1") == "roleplayer2")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot1 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot1 = Random.Range(7, 16);
            }
            if (PointsSlot1 >= 7)
            {
                Invoke("PlayCrowSound", 4f);
            }
            else
            {
                Invoke("PlayAwwSound", 4f);
            }
        }
        if (PlayerPrefs.GetString("Tag1") == "roleplayer3")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot1 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot1 = Random.Range(7, 16);
            }
            if (PointsSlot1 >= 7)
            {
                Invoke("PlayCrowSound", 4f);
            }
            else
            {
                Invoke("PlayAwwSound", 4f);
            }
        }
        if (PlayerPrefs.GetString("Tag1") == "benchwarmer")
        {
            PointsSlot1 = Random.Range(2, 7);
            Invoke("PlayAwwSound", 4f);
        }
        //Slot2
        if (PlayerPrefs.GetString("Tag2") == "superstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot2 = Random.Range(10, 16);
            }
            else
            {
                PointsSlot2 = Random.Range(25, 36);
            }
            if (PointsSlot2 >= 25)
            {
                Invoke("PlayCrowSound", 6f);
            }
            else
            {
                Invoke("PlayAwwSound", 6f);
            }
        }
        if (PlayerPrefs.GetString("Tag2") == "allstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot2 = Random.Range(7, 11);
            }
            else
            {
                PointsSlot2 = Random.Range(15, 28);
            }
            if (PointsSlot2 >= 15)
            {
                Invoke("PlayCrowSound", 6f);
            }
            else
            {
                Invoke("PlayAwwSound", 6f);
            }
        }
        if (PlayerPrefs.GetString("Tag2") == "roleplayer")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot2 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot2 = Random.Range(7, 16);
            }
            if (PointsSlot2 >= 7)
            {
                Invoke("PlayCrowSound", 6f);
            }
            else
            {
                Invoke("PlayAwwSound", 6f);
            }
        }
        if (PlayerPrefs.GetString("Tag2") == "roleplayer2")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot2 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot2 = Random.Range(7, 16);
            }
            if (PointsSlot2 >= 7)
            {
                Invoke("PlayCrowSound", 6f);
            }
            else
            {
                Invoke("PlayAwwSound", 6f);
            }
        }
        if (PlayerPrefs.GetString("Tag2") == "roleplayer3")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot2 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot2 = Random.Range(7, 16);
            }
            if (PointsSlot2 >= 7)
            {
                Invoke("PlayCrowSound", 6f);
            }
            else
            {
                Invoke("PlayAwwSound", 6f);
            }
        }
        if (PlayerPrefs.GetString("Tag2") == "benchwarmer")
        {
            PointsSlot2 = Random.Range(2, 7);
            Invoke("PlayAwwSound", 6f);
        }
        //Slot3
        if (PlayerPrefs.GetString("Tag3") == "superstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot3 = Random.Range(10, 16);
            }
            else
            {
                PointsSlot3 = Random.Range(25, 36);
            }
            if (PointsSlot3 >= 25)
            {
                Invoke("PlayCrowSound", 8f);
            }
            else
            {
                Invoke("PlayAwwSound", 8f);
            }
        }
        if (PlayerPrefs.GetString("Tag3") == "allstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot3 = Random.Range(7, 11);
            }
            else
            {
                PointsSlot3 = Random.Range(15, 28);
            }
            if (PointsSlot3 >= 15)
            {
                Invoke("PlayCrowSound", 8f);
            }
            else
            {
                Invoke("PlayAwwSound", 8f);
            }
        }
        if (PlayerPrefs.GetString("Tag3") == "roleplayer")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot3 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot3 = Random.Range(7, 16);
            }
            if (PointsSlot3 >= 7)
            {
                Invoke("PlayCrowSound", 8f);
            }
            else
            {
                Invoke("PlayAwwSound", 8f);
            }
        }
        if (PlayerPrefs.GetString("Tag3") == "roleplayer2")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot3 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot3 = Random.Range(7, 16);
            }
            if (PointsSlot3 >= 7)
            {
                Invoke("PlayCrowSound", 8f);
            }
            else
            {
                Invoke("PlayAwwSound", 8f);
            }
        }
        if (PlayerPrefs.GetString("Tag3") == "roleplayer3")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot3 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot3 = Random.Range(7, 16);
            }
            if (PointsSlot3 >= 7)
            {
                Invoke("PlayCrowSound", 8f);
            }
            else
            {
                Invoke("PlayAwwSound", 8f);
            }
        }
        if (PlayerPrefs.GetString("Tag3") == "benchwarmer")
        {
            PointsSlot3 = Random.Range(2, 7);
            Invoke("PlayAwwSound", 8f);
        }
        //Slot4
        if (PlayerPrefs.GetString("Tag4") == "superstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot4 = Random.Range(10, 16);
            }
            else
            {
                PointsSlot4 = Random.Range(25, 36);
            }
            if (PointsSlot4 >= 25)
            {
                Invoke("PlayCrowSound", 10f);
            }
            else
            {
                Invoke("PlayAwwSound", 10f);
            }
        }
        if (PlayerPrefs.GetString("Tag4") == "allstar")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot4 = Random.Range(7, 11);
            }
            else
            {
                PointsSlot4 = Random.Range(15, 28);
            }
            if (PointsSlot4 >= 15)
            {
                Invoke("PlayCrowSound", 10f);
            }
            else
            {
                Invoke("PlayAwwSound", 10f);
            }
        }
        if (PlayerPrefs.GetString("Tag4") == "roleplayer")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot4 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot4 = Random.Range(7, 16);
            }
            if (PointsSlot4 >= 7)
            {
                Invoke("PlayCrowSound", 10f);
            }
            else
            {
                Invoke("PlayAwwSound", 10f);
            }
        }
        if (PlayerPrefs.GetString("Tag4") == "roleplayer2")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot4 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot4 = Random.Range(7, 16);
            }
            if (PointsSlot4 >= 7)
            {
                Invoke("PlayCrowSound", 10f);
            }
            else
            {
                Invoke("PlayAwwSound", 10f);
            }
        }
        if (PlayerPrefs.GetString("Tag4") == "roleplayer3")
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                PointsSlot4 = Random.Range(2, 7);
            }
            else
            {
                PointsSlot4 = Random.Range(7, 16);
            }
            if (PointsSlot4 >= 7)
            {
                Invoke("PlayCrowSound", 10f);
            }
            else
            {
                Invoke("PlayAwwSound", 10f);
            }
        }
        if (PlayerPrefs.GetString("Tag4") == "benchwarmer")
        {
            PointsSlot4 = Random.Range(2, 7);
            Invoke("PlayAwwSound", 10f);
        }

        PoolGame = GameObject.FindGameObjectWithTag("PoolGame");
        PoolGame.transform.position = (PoolGamePosition.transform.position);
    }
    private void CardsPoints()
    {

    }
    private void Start()
    {
        Invoke("PlaySoundSlotMachine", 0.5f);
        Invoke("PlaySoundSevens", 1.8f);
        Invoke("PlaySoundSlotEnd", 10.5f); 
        CardValue();
        ScoreSlotValue();
        if (PlayerPrefs.GetInt("BattleNumber") == 1)
        {
            Round1End.SetActive(true);
            if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
            {
                PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle1", 1);
            }
            if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
            {
                PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle1", 1);
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 2)
        {
            Round2End.SetActive(true);
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
            {
                StaticBall1Player1.SetActive(true); //Activates ball image to show player has won 1 battle before
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
            {
                StaticBall1CPU.SetActive(true); //Activates ball image to show player has won 1 battle before
            }

            if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 0);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 1);
                }
            }
            if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 0);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 1);
                }
            }
            if (PlayerPrefs.GetInt("ScorePlayer1") == PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle2", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle2", 2);
                }
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 3)
        {
            Round3End.SetActive(true);
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
            {
                StaticBall1Player1.SetActive(true); //Activates ball image to show player has won 1 battle before
            }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
            {
                StaticBall1Player1.SetActive(true); 
                StaticBall2Player1.SetActive(true); 
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
            {
                StaticBall1CPU.SetActive(true); //Activates ball image to show CPU has won 1 battle before
            }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
            {
                StaticBall1CPU.SetActive(true);
                StaticBall2CPU.SetActive(true);
            }

            if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 3);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 0);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 2);
                }
            }
            if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle3", 3);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 0);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle3", 2);
                }
            }
        }
        if (PlayerPrefs.GetInt("BattleNumber") == 4)
        {
            Round4End.SetActive(true);
            Debug.Log(PlayerPrefs.GetInt("ScorePlayer1"));
            Debug.Log(PlayerPrefs.GetInt("ScoreCPU"));
            Debug.Log(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3"));
            Debug.Log(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3"));
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 1)
                {
                    StaticBall1Player1.SetActive(true); //Activates ball image to show player has won 1 battle before
                }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 2)
                {
                    StaticBall1Player1.SetActive(true);
                    StaticBall2Player1.SetActive(true);
                }
            if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 3)
                {
                    StaticBall1Player1.SetActive(true);
                    StaticBall2Player1.SetActive(true);
                    StaticBall3Player1.SetActive(true);
                }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 1)
                {
                    StaticBall1CPU.SetActive(true); //Activates ball image to show CPU has won 1 battle before
                }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 2)
                {
                    StaticBall1CPU.SetActive(true);
                    StaticBall2CPU.SetActive(true);
                }
            if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 3)
                {
                    StaticBall1CPU.SetActive(true);
                    StaticBall2CPU.SetActive(true);
                    StaticBall3CPU.SetActive(true);
                }

            if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 0)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 1);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 1)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 2);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 2)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 3);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 3)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 4);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 0)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 0);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 1)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 1);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 2)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 2);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 3)
                    {
                        PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 3);
                    }
                }
            if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
            {
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 3);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 3)
                {
                    PlayerPrefs.SetInt("GlobalBattleScoreCPUBattle4", 4);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 0)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 0);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 1)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 1);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 2)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 2);
                }
                if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 3)
                {
                    PlayerPrefs.SetInt("GlobalBattleScorePlayer1Battle4", 3);
                }
            }
        }
        Debug.Log(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3"));
        Debug.Log(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3"));
        Debug.Log(PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle4"));
        Debug.Log(PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle4"));
        Destroy(Sevens0, 2f);
        Destroy(Sevens1, 4f);
        Destroy(Sevens2, 6f);
        Destroy(Sevens3, 8f);
        Destroy(Sevens4, 10f);
        Destroy(Sevens5, 2f);
        Destroy(Sevens6, 4f);
        Destroy(Sevens7, 6f);
        Destroy(Sevens8, 8f);
        Destroy(Sevens9, 10f);
        Destroy(SlotsPlayer, 10.5f);
        Destroy(SlotsCPU, 10.5f);
        Destroy(Round1End, 15f);
        Destroy(Round2End, 15f);
        Destroy(Round3End, 15f);
        Destroy(Round4End, 15f);
    }


    private void Update()
    {
        AnimationActivator();
        SceneSelecterCardsBack();
        if (SlotsPlayer == null)
        {
            SlotMachine.Stop();
            Sevens.Stop();
        }
    }

    void PlaySoundSlotMachine()
    {
        SlotMachine.Play();
    }
    void PlaySoundSevens()
    {
        Sevens.Play();
    }
    void PlaySoundSlotEnd()
    {
        SlotEnd.Play();
    }
    void PlayCrowSound()
    {
        Crow.Play();
    }
    void PlayAwwSound()
    {
        Aww.Play();
    }
    public void CardValue()
    {
        // Slot #0
        if (PlayerPrefs.GetInt("Value0") <= 55 && PlayerPrefs.GetInt("Value0") >= 50)//SuperStar
        {
            CopiedCards[0] = Instantiate(OriginalCards[0], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
        }
        if (PlayerPrefs.GetInt("Value0") <= 49 && PlayerPrefs.GetInt("Value0") >= 40)//AllStar
        {
            CopiedCards[0] = Instantiate(OriginalCards[1], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
        }
        if (PlayerPrefs.GetInt("Value0") <= 39 && PlayerPrefs.GetInt("Value0") >= 30)//Roleplayer
        {
            CopiedCards[0] = Instantiate(OriginalCards[2], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value0") <= 29 && PlayerPrefs.GetInt("Value0") >= 20)//Roleplayer2
        {
            CopiedCards[0] = Instantiate(OriginalCards[3], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value0") <= 19 && PlayerPrefs.GetInt("Value0") >= 10)//Roleplayer3
        {
            CopiedCards[0] = Instantiate(OriginalCards[4], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value0") <= 9 && PlayerPrefs.GetInt("Value0") >= 1)//BenchWarmer
        {
            CopiedCards[0] = Instantiate(OriginalCards[5], Slots[0].parent);
            ScoreSlot0.GetComponent<TextMeshProUGUI>().color = Color.black;
            TextScoreSlot0.GetComponent<TextMeshProUGUI>().color = Color.black;
        }

        // Slot #1
        if (PlayerPrefs.GetInt("Value1") <= 55 && PlayerPrefs.GetInt("Value1") >= 50)//SuperStar
        {
            CopiedCards[1] = Instantiate(OriginalCards[0], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
        }
        if (PlayerPrefs.GetInt("Value1") <= 49 && PlayerPrefs.GetInt("Value1") >= 40)//AllStar
        {
            CopiedCards[1] = Instantiate(OriginalCards[1], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
        }
        if (PlayerPrefs.GetInt("Value1") <= 39 && PlayerPrefs.GetInt("Value1") >= 30)//Roleplayer
        {
            CopiedCards[1] = Instantiate(OriginalCards[2], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value1") <= 29 && PlayerPrefs.GetInt("Value1") >= 20)//Roleplayer2
        {
            CopiedCards[1] = Instantiate(OriginalCards[3], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value1") <= 19 && PlayerPrefs.GetInt("Value1") >= 10)//Roleplayer3
        {
            CopiedCards[1] = Instantiate(OriginalCards[4], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value1") <= 9 && PlayerPrefs.GetInt("Value1") >= 1)//BenchWarmer
        {
            CopiedCards[1] = Instantiate(OriginalCards[5], Slots[1].parent);
            ScoreSlot1.GetComponent<TextMeshProUGUI>().color = Color.black;
            TextScoreSlot1.GetComponent<TextMeshProUGUI>().color = Color.black;
        }

        // Slot #2
        if (PlayerPrefs.GetInt("Value2") <= 55 && PlayerPrefs.GetInt("Value2") >= 50)//SuperStar
        {
            CopiedCards[2] = Instantiate(OriginalCards[0], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
        }
        if (PlayerPrefs.GetInt("Value2") <= 49 && PlayerPrefs.GetInt("Value2") >= 40)//AllStar
        {
            CopiedCards[2] = Instantiate(OriginalCards[1], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
        }
        if (PlayerPrefs.GetInt("Value2") <= 39 && PlayerPrefs.GetInt("Value2") >= 30)//Roleplayer
        {
            CopiedCards[2] = Instantiate(OriginalCards[2], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value2") <= 29 && PlayerPrefs.GetInt("Value2") >= 20)//Roleplayer2
        {
            CopiedCards[2] = Instantiate(OriginalCards[3], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value2") <= 19 && PlayerPrefs.GetInt("Value2") >= 10)//Roleplayer3
        {
            CopiedCards[2] = Instantiate(OriginalCards[4], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value2") <= 9 && PlayerPrefs.GetInt("Value2") >= 1)//BenchWarmer
        {
            CopiedCards[2] = Instantiate(OriginalCards[5], Slots[2].parent);
            ScoreSlot2.GetComponent<TextMeshProUGUI>().color = Color.black;
            TextScoreSlot2.GetComponent<TextMeshProUGUI>().color = Color.black;
        }

        // Slot #3
        if (PlayerPrefs.GetInt("Value3") <= 55 && PlayerPrefs.GetInt("Value3") >= 50)//SuperStar
        {
            CopiedCards[3] = Instantiate(OriginalCards[0], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
        }
        if (PlayerPrefs.GetInt("Value3") <= 49 && PlayerPrefs.GetInt("Value3") >= 40)//AllStar
        {
            CopiedCards[3] = Instantiate(OriginalCards[1], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
        }
        if (PlayerPrefs.GetInt("Value3") <= 39 && PlayerPrefs.GetInt("Value3") >= 30)//Roleplayer
        {
            CopiedCards[3] = Instantiate(OriginalCards[2], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value3") <= 29 && PlayerPrefs.GetInt("Value3") >= 20)//Roleplayer2
        {
            CopiedCards[3] = Instantiate(OriginalCards[3], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value3") <= 19 && PlayerPrefs.GetInt("Value3") >= 10)//Roleplayer3
        {
            CopiedCards[3] = Instantiate(OriginalCards[4], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value3") <= 9 && PlayerPrefs.GetInt("Value3") >= 1)//BenchWarmer
        {
            CopiedCards[3] = Instantiate(OriginalCards[5], Slots[3].parent);
            ScoreSlot3.GetComponent<TextMeshProUGUI>().color = Color.black;
            TextScoreSlot3.GetComponent<TextMeshProUGUI>().color = Color.black;
        }

        // Slot #4
        if (PlayerPrefs.GetInt("Value4") <= 55 && PlayerPrefs.GetInt("Value4") >= 50)//SuperStar
        {
            CopiedCards[4] = Instantiate(OriginalCards[0], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
        }
        if (PlayerPrefs.GetInt("Value4") <= 49 && PlayerPrefs.GetInt("Value4") >= 40)//AllStar
        {
            CopiedCards[4] = Instantiate(OriginalCards[1], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
        }
        if (PlayerPrefs.GetInt("Value4") <= 39 && PlayerPrefs.GetInt("Value4") >= 30)//Roleplayer
        {
            CopiedCards[4] = Instantiate(OriginalCards[2], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value4") <= 29 && PlayerPrefs.GetInt("Value4") >= 20)//Roleplayer2
        {
            CopiedCards[4] = Instantiate(OriginalCards[3], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value4") <= 19 && PlayerPrefs.GetInt("Value4") >= 10)//Roleplayer3
        {
            CopiedCards[4] = Instantiate(OriginalCards[4], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
        }
        if (PlayerPrefs.GetInt("Value4") <= 9 && PlayerPrefs.GetInt("Value4") >= 1)//BenchWarmer
        {
            CopiedCards[4] = Instantiate(OriginalCards[5], Slots[4].parent);
            ScoreSlot4.GetComponent<TextMeshProUGUI>().color = Color.black;
            TextScoreSlot4.GetComponent<TextMeshProUGUI>().color = Color.black;
        }

        PlayerScore.text = (PointsSlot0 + PointsSlot1 + PointsSlot2 + PointsSlot3 + PointsSlot4).ToString();
        PlayerPrefs.SetInt("ScorePlayer1", (PointsSlot0 + PointsSlot1 + PointsSlot2 + PointsSlot3 + PointsSlot4));

    }

    public void ScoreSlotValue()
    {
        ScoreSlot0.text = PointsSlot0.ToString();
        int ValueScoreSlot0 = PointsSlot0;
        ScoreSlot1.text = PointsSlot1.ToString();
        int ValueScoreSlot1 = PointsSlot1;
        ScoreSlot2.text = PointsSlot2.ToString();
        int ValueScoreSlot2 = PointsSlot2;
        ScoreSlot3.text = PointsSlot3.ToString();
        int ValueScoreSlot3 = PointsSlot3;
        ScoreSlot4.text = PointsSlot4.ToString();
        int ValueScoreSlot4 = PointsSlot4;
        // Slot 5 CPU 0
        if (ValueScoreSlot0 <= 35 && ValueScoreSlot0 >= 15) 
        {
            int ValueScoreSlot5 = Random.Range(15, 36);
            ScoreSlot5.text = ValueScoreSlot5.ToString();
            PlayerPrefs.SetInt("Value5", ValueScoreSlot5);
            if (ValueScoreSlot5 <= 35 && ValueScoreSlot5 >= 25) //SuperStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[0], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot5 <= 24 && ValueScoreSlot5 >= 15) //AllStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[1], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
        }
        if (ValueScoreSlot0 <= 14 && ValueScoreSlot0 >= 2)
        {
            int ValueScoreSlot5 = Random.Range(2, 15);
            ScoreSlot5.text = ValueScoreSlot5.ToString();
            PlayerPrefs.SetInt("Value5", ValueScoreSlot5);
            if (ValueScoreSlot5 == 14) //SuperStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[0], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot5 == 13) //AllStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[1], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
            if (ValueScoreSlot5 <= 12 && ValueScoreSlot5 >= 10) //RolePlayer
            {
                CopiedCards[5] = Instantiate(OriginalCards[2], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot5 == 9) //RolePlayer2
            {
                CopiedCards[5] = Instantiate(OriginalCards[3], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot5 == 8) //RolePlayer3
            {
                CopiedCards[5] = Instantiate(OriginalCards[4], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot5 <= 7 && ValueScoreSlot5 >= 2) //Benchwarmer
            {
                CopiedCards[5] = Instantiate(OriginalCards[5], Slots[5].parent);
                ScoreSlot5.GetComponent<TextMeshProUGUI>().color = Color.black;
                TextScoreSlot5.GetComponent<TextMeshProUGUI>().color = Color.black;
            }
        }
        // Slot 6 CPU 1
        if (ValueScoreSlot1 <= 35 && ValueScoreSlot1 >= 15)
        {
            int ValueScoreSlot6 = Random.Range(15, 36);
            ScoreSlot6.text = ValueScoreSlot6.ToString();
            PlayerPrefs.SetInt("Value6", ValueScoreSlot6);
            if (ValueScoreSlot6 <= 35 && ValueScoreSlot6 >= 25) //SuperStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[0], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot6 <= 24 && ValueScoreSlot6 >= 15) //AllStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[1], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
        }
        if (ValueScoreSlot1 <= 14 && ValueScoreSlot1 >= 2)
        {
            int ValueScoreSlot6 = Random.Range(2, 15);
            ScoreSlot6.text = ValueScoreSlot6.ToString();
            PlayerPrefs.SetInt("Value6", ValueScoreSlot6);
            if (ValueScoreSlot6 == 14) //SuperStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[0], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot6 == 13) //AllStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[1], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }

            if (ValueScoreSlot6 <= 12 && ValueScoreSlot6 >= 10) //RolePlayer
            {
                CopiedCards[6] = Instantiate(OriginalCards[2], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot6 == 9) //RolePlayer2
            {
                CopiedCards[6] = Instantiate(OriginalCards[3], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot6 == 8) //RolePlayer3
            {
                CopiedCards[6] = Instantiate(OriginalCards[4], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot6 <= 7 && ValueScoreSlot6 >= 2) //Benchwarmer
            {
                CopiedCards[6] = Instantiate(OriginalCards[5], Slots[6].parent);
                ScoreSlot6.GetComponent<TextMeshProUGUI>().color = Color.black;
                TextScoreSlot6.GetComponent<TextMeshProUGUI>().color = Color.black;
            }
        }
        // Slot 7 CPU 2
        if (ValueScoreSlot2 <= 35 && ValueScoreSlot2 >= 15)
        {
            int ValueScoreSlot7 = Random.Range(15, 36);
            ScoreSlot7.text = ValueScoreSlot7.ToString();
            PlayerPrefs.SetInt("Value7", ValueScoreSlot7);
            if (ValueScoreSlot7 <= 35 && ValueScoreSlot7 >= 25) //SuperStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[0], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot7 <= 24 && ValueScoreSlot7 >= 15) //AllStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[1], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
        }
        if (ValueScoreSlot2 <= 14 && ValueScoreSlot2 >= 2)
        {
            int ValueScoreSlot7 = Random.Range(2, 15);
            ScoreSlot7.text = ValueScoreSlot7.ToString();
            PlayerPrefs.SetInt("Value7", ValueScoreSlot7);
            if (ValueScoreSlot7 == 14) //SuperStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[0], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot7 == 13) //AllStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[1], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }

            if (ValueScoreSlot7 <= 12 && ValueScoreSlot7 >= 10) //RolePlayer
            {
                CopiedCards[7] = Instantiate(OriginalCards[2], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot7 == 9) //RolePlayer2
            {
                CopiedCards[7] = Instantiate(OriginalCards[3], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot7 == 8) //RolePlayer3
            {
                CopiedCards[7] = Instantiate(OriginalCards[4], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot7 <= 7 && ValueScoreSlot7 >= 2) //Benchwarmer
            {
                CopiedCards[7] = Instantiate(OriginalCards[5], Slots[7].parent);
                ScoreSlot7.GetComponent<TextMeshProUGUI>().color = Color.black;
                TextScoreSlot7.GetComponent<TextMeshProUGUI>().color = Color.black;
            }
        }
        // Slot 8 CPU 3
        if (ValueScoreSlot3 <= 35 && ValueScoreSlot3 >= 15)
        {
            int ValueScoreSlot8 = Random.Range(15, 36);
            ScoreSlot8.text = ValueScoreSlot8.ToString();
            PlayerPrefs.SetInt("Value8", ValueScoreSlot8);
            if (ValueScoreSlot8 <= 35 && ValueScoreSlot8 >= 25) //SuperStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[0], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot8 <= 24 && ValueScoreSlot8 >= 15) //AllStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[1], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
        }
        if (ValueScoreSlot3 <= 14 && ValueScoreSlot3 >= 2)
        {
            int ValueScoreSlot8 = Random.Range(2, 15);
            ScoreSlot8.text = ValueScoreSlot8.ToString();
            PlayerPrefs.SetInt("Value8", ValueScoreSlot8);
            if (ValueScoreSlot8 == 14) //SuperStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[0], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot8 == 13) //AllStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[1], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
            if (ValueScoreSlot8 <= 12 && ValueScoreSlot8 >= 10) //RolePlayer
            {
                CopiedCards[8] = Instantiate(OriginalCards[2], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot8 == 9) //RolePlayer2
            {
                CopiedCards[8] = Instantiate(OriginalCards[3], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot8 == 8) //RolePlayer3
            {
                CopiedCards[8] = Instantiate(OriginalCards[4], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot8 <= 7 && ValueScoreSlot8 >= 2) //Benchwarmer
            {
                CopiedCards[8] = Instantiate(OriginalCards[5], Slots[8].parent);
                ScoreSlot8.GetComponent<TextMeshProUGUI>().color = Color.black;
                TextScoreSlot8.GetComponent<TextMeshProUGUI>().color = Color.black;
            }
        }
        // Slot 9 CPU 4
        if (ValueScoreSlot4 <= 35 && ValueScoreSlot4 >= 15)
        {
            int ValueScoreSlot9 = Random.Range(15, 36);
            ScoreSlot9.text = ValueScoreSlot9.ToString();
            PlayerPrefs.SetInt("Value9", ValueScoreSlot9);
            if (ValueScoreSlot9 <= 35 && ValueScoreSlot9 >= 25) //SuperStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[0], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot9 <= 24 && ValueScoreSlot9 >= 15) //AllStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[1], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
        }
        if (ValueScoreSlot4 <= 14 && ValueScoreSlot4 >= 2)
        {
            int ValueScoreSlot9 = Random.Range(2, 15);
            ScoreSlot9.text = ValueScoreSlot9.ToString();
            PlayerPrefs.SetInt("Value9", ValueScoreSlot9);
            if (ValueScoreSlot9 == 14) //SuperStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[0], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.6156863f, 0f);
            }
            if (ValueScoreSlot9 == 13) //AllStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[1], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.145098f, 0.172549f, 0.3647059f);
            }
            if (ValueScoreSlot9 <= 12 && ValueScoreSlot9 >= 10) //RolePlayer
            {
                CopiedCards[9] = Instantiate(OriginalCards[2], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot9 == 9) //RolePlayer2
            {
                CopiedCards[9] = Instantiate(OriginalCards[3], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot9 == 8) //RolePlayer3
            {
                CopiedCards[9] = Instantiate(OriginalCards[4], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = new Color(0.7215686f, 0.5686275f, 0.3686275f);
            }
            if (ValueScoreSlot9 <= 7 && ValueScoreSlot9 >= 2) //Benchwarmer
            {
                CopiedCards[9] = Instantiate(OriginalCards[5], Slots[9].parent);
                ScoreSlot9.GetComponent<TextMeshProUGUI>().color = Color.black;
                TextScoreSlot9.GetComponent<TextMeshProUGUI>().color = Color.black;
            }
        }
        CPUScore.text = (PlayerPrefs.GetInt("Value5") + PlayerPrefs.GetInt("Value6") + PlayerPrefs.GetInt("Value7") + PlayerPrefs.GetInt("Value8")
            + PlayerPrefs.GetInt("Value9")).ToString();
        PlayerPrefs.SetInt("ScoreCPU", (PlayerPrefs.GetInt("Value5") + PlayerPrefs.GetInt("Value6") + PlayerPrefs.GetInt("Value7") + PlayerPrefs.GetInt("Value8")
            + PlayerPrefs.GetInt("Value9")));
    }

    public void AnimationActivator() // FUNCTION TO ACTIVATE BASKETBALL ANIMATIONS WHEN WIN BATTLE
    {
        if (SlotsCPU == null)
        {
            if (PlayerPrefs.GetInt("BattleNumber") == 1)
            {
                if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
                {
                    Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                }
                else if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
                {
                    Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                }
                else
                {
                    Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                    Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                }
            }

            if (PlayerPrefs.GetInt("BattleNumber") == 2) //When battle 2 starts
            {
                if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 0)
                    {
                        Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                    } 
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
                    {
                        Ball2Player1Animator.SetBool("ActivateBall1Player1", true);
                    }
                }
                if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 0)
                    {
                        Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
                    {
                        Ball2CPUAminator.SetBool("ActivateBall1CPU", true);
                    }
                }
                if (PlayerPrefs.GetInt("ScorePlayer1") == PlayerPrefs.GetInt("ScoreCPU"))
                {
                    
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 0)
                    {
                        Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle1") == 1)
                    {
                        Ball2Player1Animator.SetBool("ActivateBall1Player1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 0)
                    {
                        Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle1") == 1)
                    {
                        Ball2CPUAminator.SetBool("ActivateBall1CPU", true);
                    }
                    
                }

            }
            if (PlayerPrefs.GetInt("BattleNumber") == 3)
            {
                if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 0)
                    {
                        Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
                    {
                        Ball2Player1Animator.SetBool("ActivateBall1Player1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
                    {
                        Ball3Player1Animator.SetBool("ActivateBall2Player1", true);
                    }
                }
                if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 0)
                    {
                        Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
                    {
                        Ball2CPUAminator.SetBool("ActivateBall1CPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
                    {
                        Ball3CPUAminator.SetBool("ActivateBall2CPU", true);
                    }
                }
                if (PlayerPrefs.GetInt("ScorePlayer1") == PlayerPrefs.GetInt("ScoreCPU"))
                {
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 0)
                    {
                        Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 1)
                    {
                        Ball2Player1Animator.SetBool("ActivateBall1Player1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle2") == 2)
                    {
                        Ball3Player1Animator.SetBool("ActivateBall2Player1", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 0)
                    {
                        Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 1)
                    {
                        Ball2CPUAminator.SetBool("ActivateBall1CPU", true);
                    }
                    if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle2") == 2)
                    {
                        Ball3CPUAminator.SetBool("ActivateBall2CPU", true);
                    }
                }
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 4)
            {
                if (PlayerPrefs.GetInt("ScorePlayer1") > PlayerPrefs.GetInt("ScoreCPU"))
                    {
                        if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 0)
                        {
                            Ball1Player1Animator.SetBool("ActivateBallPlayer1", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 1)
                        {
                            Ball2Player1Animator.SetBool("ActivateBall1Player1", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 2)
                        {
                            Ball3Player1Animator.SetBool("ActivateBall2Player1", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScorePlayer1Battle3") == 3)
                        {
                            Ball4Player1Animator.SetBool("ActivateBall3Player1", true);
                        }
                    }
                if (PlayerPrefs.GetInt("ScorePlayer1") < PlayerPrefs.GetInt("ScoreCPU"))
                    {
                        if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 0)
                        {
                            Ball1CPUAminator.SetBool("ActivateBallCPU", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 1)
                        {
                            Ball2CPUAminator.SetBool("ActivateBall1CPU", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 2)
                        {
                            Ball3CPUAminator.SetBool("ActivateBall2CPU", true);
                        }
                        if (PlayerPrefs.GetInt("GlobalBattleScoreCPUBattle3") == 3)
                        {
                            Ball4CPUAminator.SetBool("ActivateBall3CPU", true);
                        }
                    }
            }
        }
    }

    public void SceneSelecterCardsBack()
    {
        if (Round1End == null)
        {
            if (PlayerPrefs.GetInt("BattleNumber") == 1)
            {
                SceneManager.LoadScene(4); //A1. Main Screen
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 2)
            {
                SceneManager.LoadScene(4); //A1. Main Screen
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 3)
            {
                SceneManager.LoadScene(4); //A1. Main Screen
            }
            if (PlayerPrefs.GetInt("BattleNumber") == 4)
            {
                SceneManager.LoadScene(4); //A1. Main Screen
            }
        }
    }
}
