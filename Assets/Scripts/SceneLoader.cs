using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadProfileScene()
    {
        if (PlayerPrefs.GetString("userinfo") == "yes")
            SceneManager.LoadScene(2);
        else
            SceneManager.LoadScene(1);
    }
    public void LoadA0Scene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadMainScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadA3Scene()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene(8);
    }
    public void LoadMultiPlayer()
    {
        SceneManager.LoadScene(10);
    }
}
