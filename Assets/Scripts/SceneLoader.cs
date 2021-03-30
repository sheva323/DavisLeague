using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadProfileScene()
    {
        if (PlayerPrefs.GetString("userinfo") == "yes")
        {
            PlayerPrefs.SetInt("BattleNumber", 0);
            SceneManager.LoadScene("A1. Main Screen");
        }
        else
            SceneManager.LoadScene("A0-1. Profile");
    }
    public void LoadA0Scene()
    {
        SceneManager.LoadScene("A0. Intro");
    }
    public void LoadMainScreen()
    {
        PlayerPrefs.SetInt("BattleNumber", 0);
        SceneManager.LoadScene("A1. Main Screen");
    }

    public void LoadA3Scene()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("A6.Settings");
    }
    public void LoadMultiPlayer()
    {
        SceneManager.LoadScene("B1.MultiplayerMenu");
    }
}
