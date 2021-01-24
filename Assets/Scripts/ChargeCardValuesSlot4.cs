using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot4 : MonoBehaviour
{
    public void Awake()
    {
        CardValue4();
    }
    public void CardValue4()
    {
        Debug.Log(PlayerPrefs.GetInt("Value4"));
        if (PlayerPrefs.GetInt("Value4") <= 40 && PlayerPrefs.GetInt("Value4") >= 30)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value4") <= 29 && PlayerPrefs.GetInt("Value4") >= 20)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value4") <= 19 && PlayerPrefs.GetInt("Value4") >= 10)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
