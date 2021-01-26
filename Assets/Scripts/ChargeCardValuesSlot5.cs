using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot5 : MonoBehaviour
{
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        CardValue5();
    }
    public void CardValue5()
    {
        if (PlayerPrefs.GetInt("Value5") <= 55 && PlayerPrefs.GetInt("Value5") >= 50)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value5") <= 49 && PlayerPrefs.GetInt("Value5") >= 40)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value5") <= 39 && PlayerPrefs.GetInt("Value5") >= 10)
        {
            transform.GetChild(Random.Range(2, 4)).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value5") <= 9 && PlayerPrefs.GetInt("Value5") >= 1)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
