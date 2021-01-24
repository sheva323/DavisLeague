using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot5 : MonoBehaviour
{
    public void Awake()
    {
        CardValue5();
    }
    public void CardValue5()
    {
        Debug.Log(PlayerPrefs.GetInt("Value5"));
        if (PlayerPrefs.GetInt("Value5") <= 40 && PlayerPrefs.GetInt("Value5") >= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value5") <= 29 && PlayerPrefs.GetInt("Value5") >= 20)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value5") <= 19 && PlayerPrefs.GetInt("Value5") >= 10)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
