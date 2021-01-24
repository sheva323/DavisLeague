using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot3 : MonoBehaviour
{
    public void Awake()
    {
        CardValue3();
    }
    public void CardValue3()
    {
        Debug.Log(PlayerPrefs.GetInt("Value3"));
        if (PlayerPrefs.GetInt("Value3") <= 40 && PlayerPrefs.GetInt("Value3") >= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value3") <= 29 && PlayerPrefs.GetInt("Value3") >= 20)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value3") <= 19 && PlayerPrefs.GetInt("Value3") >= 10)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
