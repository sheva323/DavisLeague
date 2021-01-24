using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChargeCardValues : MonoBehaviour
{
    public void Awake()
    {
        CardValue1();
    }
    public void CardValue1 ()
    {
        if (PlayerPrefs.GetInt("Value1")<=40 && PlayerPrefs.GetInt("Value1") >= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value1") <= 29 && PlayerPrefs.GetInt("Value1") >= 20)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value1") <= 19 && PlayerPrefs.GetInt("Value1") >= 10)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else 
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
