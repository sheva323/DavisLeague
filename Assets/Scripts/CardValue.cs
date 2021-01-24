﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardValue : MonoBehaviour
{
    public int Cardvalue;
    public string tagCard;
    public Text textValue;

    private void Start()
    {
        textValue = GetComponentInChildren<Text>();
        tagCard = this.tag;
        ValueInCard();
        print(tagCard);

    }
    public void ValueInCard ()
    {
        switch (tagCard)
        {
            case "allstar":
                Cardvalue = Random.Range(20, 29);
                textValue.text = Cardvalue.ToString();
                break;
            case "roleplayer":
                Cardvalue = Random.Range(10, 19);
                textValue.text = Cardvalue.ToString();
                break;
            case "benchwarmer":
                Cardvalue = Random.Range(1, 9);
                textValue.text = Cardvalue.ToString();
                break;
            case "superstar":
                Cardvalue = Random.Range(30, 40);
                textValue.text = Cardvalue.ToString();
                break;
            default:
                break;
        }
    }
}
