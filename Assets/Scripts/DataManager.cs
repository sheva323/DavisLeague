using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public Text UserName;
    public Text UserMaxScore;
    void Start()
    {
        UserName.text = PlayerPrefs.GetString("username");
        UserMaxScore.text = "845";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button()
    {
        SceneManager.LoadScene(0);
    }
}
