using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public InputField UserName;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UserNameFunction()
    {
        PlayerPrefs.SetString("username", UserName.text);
    }
}
