using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    public Transform Slot0;
    public Transform Slot1;
    public Transform Slot2;
    public Transform Slot3;
    public Transform Slot4;
    public GameObject[] ToHide;
    public GameObject[] ToShow;
    public GameObject ButtonGetHand;
    public bool GetHandButton;
    // Start is called before the first frame update
    void Start()
    {
        GetHandButton = false;
    }

    public void LoadBattle()
    {
        if (Slot0.childCount > 0 && Slot1.childCount > 0 && Slot2.childCount > 0 && Slot3.childCount > 0 && Slot4.childCount > 0)
        {
            if (PlayerPrefs.GetInt("BattleNumber") == 1)
            {
                PlayerPrefs.SetInt("GlobalBattleScorePlayer1", 0); //Restart Number of Battles won
                PlayerPrefs.SetInt("GlobalBattleScoreCPU", 0);//Restart Number of Battles won
                PlayerPrefs.SetInt("ScorePlayer1", 0);//Restart Scoreplayer
                PlayerPrefs.SetInt("ScoreCPU", 0);//Restart Score CPU
            }
            SceneManager.LoadScene(3);
        }
        else
        {
            for (int i=0; i < ToHide.Length; i++)
            {
                ToHide[i].SetActive(false);
            }
            for (int i=0; i< ToShow.Length; i++)
            {
                ToShow[i].SetActive(true);
            }
        }
    }

    public void GotItButton()
    {
        for (int i = 0; i < ToHide.Length; i++)
        {
            ToHide[i].SetActive(true);
        }
        for (int i = 0; i < ToShow.Length; i++)
        {
            ToShow[i].SetActive(false);
        }
        if (GetHandButton)
        {
            ButtonGetHand.SetActive(true);
        }
    }
}
