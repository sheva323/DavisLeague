using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadProfileScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadA0Scene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadA1Scene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadA2Scene()
    {
        SceneManager.LoadScene(3);
        if (PlayerPrefs.GetInt("BattleNumber") == 1)
        {
            PlayerPrefs.SetInt("GlobalBattleScorePlayer1", 0); //Restart Number of Battles won
            PlayerPrefs.SetInt("GlobalBattleScoreCPU", 0);//Restart Number of Battles won
            PlayerPrefs.SetInt("ScorePlayer1", 0);//Restart Scoreplayer
            PlayerPrefs.SetInt("ScoreCPU", 0);//Restart Score CPU
        }
    }
    public void LoadA3Scene()
    {
        SceneManager.LoadScene(4);
    }
}
