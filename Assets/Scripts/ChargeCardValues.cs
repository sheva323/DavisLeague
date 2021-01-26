using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChargeCardValues : MonoBehaviour
{
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        CardValue1();
    }

    public void CardValue1 ()
    {
        if (PlayerPrefs.GetInt("Value1")<=55 && PlayerPrefs.GetInt("Value1") >= 50)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value1") <= 49 && PlayerPrefs.GetInt("Value1") >= 40)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value1") <= 39 && PlayerPrefs.GetInt("Value1") >= 10)
        {
            transform.GetChild(Random.Range(2, 4)).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value1") <= 9 && PlayerPrefs.GetInt("Value1") >= 1)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
