using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot2 : MonoBehaviour
{
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        CardValue2();
    }
    public void CardValue2()
    {
        if (PlayerPrefs.GetInt("Value2") <= 55 && PlayerPrefs.GetInt("Value2") >= 50)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value2") <= 49 && PlayerPrefs.GetInt("Value2") >= 40)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value2") <= 39 && PlayerPrefs.GetInt("Value2") >= 10)
        {
            transform.GetChild(Random.Range(2, 4)).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value2") <= 9 && PlayerPrefs.GetInt("Value2") >= 1)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
