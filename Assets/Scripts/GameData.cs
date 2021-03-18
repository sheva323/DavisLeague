using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public InputField UserName;
    public SceneLoader sceneLoader;

    public void UserNameFunction()
    {
        if (UserName.text.Length > 1)
        {
            PlayerPrefs.SetString("username", UserName.text);
            sceneLoader.LoadMainScreen();
            PlayerPrefs.SetString("userinfo", "yes");
        }
        
    }
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
