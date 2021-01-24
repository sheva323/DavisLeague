using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot2 : MonoBehaviour
{
    public void Awake()
    {
        CardValue2();
    }
    public void CardValue2()
    {
        Debug.Log(PlayerPrefs.GetInt("Value2"));
        if (PlayerPrefs.GetInt("Value2") <= 40 && PlayerPrefs.GetInt("Value2") >= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value2") <= 29 && PlayerPrefs.GetInt("Value2") >= 20)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value2") <= 19 && PlayerPrefs.GetInt("Value2") >= 10)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
