using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardValue : MonoBehaviour
{
    public int Cardvalue;
    public string tagCard;
    public Text textValue;

    //generates a ranged random value to 20 random cards showed on scene A1 (LOWER PART), depending on tag (allstar, roleplayer, benchwarmer or superstar)
    private void Start()
    {
        textValue = GetComponentInChildren<Text>();
        tagCard = this.tag;
        ValueInCard();
    }
    public void ValueInCard ()
    {
        switch (tagCard)
        {
            case "allstar":
                Cardvalue = Random.Range(40, 49);
                break;

            case "roleplayer":
                Cardvalue = Random.Range(30, 39);
                break;
            case "roleplayer2":
                Cardvalue = Random.Range(20, 29);
                break;
            case "roleplayer3":
                Cardvalue = Random.Range(10, 19);
                break;
            case "benchwarmer":
                Cardvalue = Random.Range(1, 9);
                break;
            case "superstar":
                Cardvalue = Random.Range(50, 55);
                break;
            default:
                break;
        }
    }
}
