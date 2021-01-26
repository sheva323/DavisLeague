using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCardValuesSlot4 : MonoBehaviour
{
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        CardValue4();
    }

    public void CardValue4()
    {
        if (PlayerPrefs.GetInt("Value4") <= 55 && PlayerPrefs.GetInt("Value4") >= 50)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value4") <= 49 && PlayerPrefs.GetInt("Value4") >= 40)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value4") <= 39 && PlayerPrefs.GetInt("Value4") >= 10)
        {
            transform.GetChild(Random.Range(2, 4)).gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Value4") <= 9 && PlayerPrefs.GetInt("Value4") >= 1)
        {
            transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
