using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public Text UserName;
    void Start()
    {
        UserName.text = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button()
    {
        SceneManager.LoadScene("A1. Main Screen");
    }
    public void TryAgain()
    {
        PlayerPrefs.SetInt("BattleNumber", 0);
        SceneManager.LoadScene("A1. Main Screen");
    }
}
