using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot3 : MonoBehaviour
{
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        CardValue3();
    }

    public void CardValue3()
    {
        if (PlayerPrefs.GetInt("Value3") <= 55 && PlayerPrefs.GetInt("Value3") >= 50)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value3") <= 49 && PlayerPrefs.GetInt("Value3") >= 40)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value3") <= 39 && PlayerPrefs.GetInt("Value3") >= 10)
        {
            transform.GetChild(Random.Range(2, 4)).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value3") <= 9 && PlayerPrefs.GetInt("Value3") >= 1)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
