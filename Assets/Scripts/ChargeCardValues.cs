using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChargeCardValues : MonoBehaviour
{
    public GameObject[] OriginalCards;
    public GameObject PanePlayer1;
    public RectTransform[] Slots;
    public GameObject[] CopiedCards;
    public TextMeshProUGUI ScoreSlot0;
    public TextMeshProUGUI ScoreSlot1;
    public TextMeshProUGUI ScoreSlot2;
    public TextMeshProUGUI ScoreSlot3;
    public TextMeshProUGUI ScoreSlot4;
    public GameObject Sevens0;
    public GameObject Sevens1;
    public GameObject Sevens2;
    public GameObject Sevens3;
    public GameObject Sevens4;
    public GameObject Sevens5;
    public GameObject Sevens6;
    public GameObject Sevens7;
    public GameObject Sevens8;
    public GameObject Sevens9;


    private void Start()
    {
        CardValue();
        ScoreSlotValue();
        Destroy(Sevens0, 2f);
        Destroy(Sevens1, 4f);
        Destroy(Sevens2, 6f);
        Destroy(Sevens3, 8f);
        Destroy(Sevens4, 10f);
        Destroy(Sevens5, 2f);
        Destroy(Sevens6, 4f);
        Destroy(Sevens7, 6f);
        Destroy(Sevens8, 8f);
        Destroy(Sevens9, 10f);
    }
    public void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void CardValue()
    {
        // Slot #1
        if (PlayerPrefs.GetInt("Value0") <= 55 && PlayerPrefs.GetInt("Value0") >= 50)//SuperStar
        {
            CopiedCards[0] = Instantiate(OriginalCards[0], Slots[0].parent);
        }
        if (PlayerPrefs.GetInt("Value0") <= 49 && PlayerPrefs.GetInt("Value0") >= 40)//AllStar
        {
            CopiedCards[0] = Instantiate(OriginalCards[1], Slots[0].parent);
        }
        if (PlayerPrefs.GetInt("Value0") <= 39 && PlayerPrefs.GetInt("Value0") >= 30)//Roleplayer
        {
            CopiedCards[0] = Instantiate(OriginalCards[2], Slots[0].parent);
        }
        if (PlayerPrefs.GetInt("Value0") <= 29 && PlayerPrefs.GetInt("Value0") >= 20)//Roleplayer2
        {
            CopiedCards[0] = Instantiate(OriginalCards[3], Slots[0].parent);
        }
        if (PlayerPrefs.GetInt("Value0") <= 19 && PlayerPrefs.GetInt("Value0") >= 10)//Roleplayer3
        {
            CopiedCards[0] = Instantiate(OriginalCards[4], Slots[0].parent);
        }
        if (PlayerPrefs.GetInt("Value0") <= 9 && PlayerPrefs.GetInt("Value0") >= 1)//BenchWarmer
        {
            CopiedCards[0] = Instantiate(OriginalCards[5], Slots[0].parent);
        }
        // Slot #2
        if (PlayerPrefs.GetInt("Value1") <= 55 && PlayerPrefs.GetInt("Value1") >= 50)//SuperStar
        {
            CopiedCards[1] = Instantiate(OriginalCards[0], Slots[1].parent);
        }
        if (PlayerPrefs.GetInt("Value1") <= 49 && PlayerPrefs.GetInt("Value1") >= 40)//AllStar
        {
            CopiedCards[1] = Instantiate(OriginalCards[1], Slots[1].parent);
        }
        if (PlayerPrefs.GetInt("Value1") <= 39 && PlayerPrefs.GetInt("Value1") >= 30)//Roleplayer
        {
            CopiedCards[1] = Instantiate(OriginalCards[2], Slots[1].parent);
        }
        if (PlayerPrefs.GetInt("Value1") <= 29 && PlayerPrefs.GetInt("Value1") >= 20)//Roleplayer2
        {
            CopiedCards[1] = Instantiate(OriginalCards[3], Slots[1].parent);
        }
        if (PlayerPrefs.GetInt("Value1") <= 19 && PlayerPrefs.GetInt("Value1") >= 10)//Roleplayer3
        {
            CopiedCards[1] = Instantiate(OriginalCards[4], Slots[1].parent);
        }
        if (PlayerPrefs.GetInt("Value1") <= 9 && PlayerPrefs.GetInt("Value1") >= 1)//BenchWarmer
        {
            CopiedCards[1] = Instantiate(OriginalCards[5], Slots[1].parent);
        }
        // Slot #3
        if (PlayerPrefs.GetInt("Value2") <= 55 && PlayerPrefs.GetInt("Value2") >= 50)//SuperStar
        {
            CopiedCards[2] = Instantiate(OriginalCards[0], Slots[2].parent);
        }
        if (PlayerPrefs.GetInt("Value2") <= 49 && PlayerPrefs.GetInt("Value2") >= 40)//AllStar
        {
            CopiedCards[2] = Instantiate(OriginalCards[1], Slots[2].parent);
        }
        if (PlayerPrefs.GetInt("Value2") <= 39 && PlayerPrefs.GetInt("Value2") >= 30)//Roleplayer
        {
            CopiedCards[2] = Instantiate(OriginalCards[2], Slots[2].parent);
        }
        if (PlayerPrefs.GetInt("Value2") <= 29 && PlayerPrefs.GetInt("Value2") >= 20)//Roleplayer2
        {
            CopiedCards[2] = Instantiate(OriginalCards[3], Slots[2].parent);
        }
        if (PlayerPrefs.GetInt("Value2") <= 19 && PlayerPrefs.GetInt("Value2") >= 10)//Roleplayer3
        {
            CopiedCards[2] = Instantiate(OriginalCards[4], Slots[2].parent);
        }
        if (PlayerPrefs.GetInt("Value2") <= 9 && PlayerPrefs.GetInt("Value2") >= 1)//BenchWarmer
        {
            CopiedCards[2] = Instantiate(OriginalCards[5], Slots[2].parent);
        }
        // Slot #4
        if (PlayerPrefs.GetInt("Value3") <= 55 && PlayerPrefs.GetInt("Value3") >= 50)//SuperStar
        {
            CopiedCards[3] = Instantiate(OriginalCards[0], Slots[3].parent);
        }
        if (PlayerPrefs.GetInt("Value3") <= 49 && PlayerPrefs.GetInt("Value3") >= 40)//AllStar
        {
            CopiedCards[3] = Instantiate(OriginalCards[1], Slots[3].parent);
        }
        if (PlayerPrefs.GetInt("Value3") <= 39 && PlayerPrefs.GetInt("Value3") >= 30)//Roleplayer
        {
            CopiedCards[3] = Instantiate(OriginalCards[2], Slots[3].parent);
        }
        if (PlayerPrefs.GetInt("Value3") <= 29 && PlayerPrefs.GetInt("Value3") >= 20)//Roleplayer2
        {
            CopiedCards[3] = Instantiate(OriginalCards[3], Slots[3].parent);
        }
        if (PlayerPrefs.GetInt("Value3") <= 19 && PlayerPrefs.GetInt("Value3") >= 10)//Roleplayer3
        {
            CopiedCards[3] = Instantiate(OriginalCards[4], Slots[3].parent);
        }
        if (PlayerPrefs.GetInt("Value3") <= 9 && PlayerPrefs.GetInt("Value3") >= 1)//BenchWarmer
        {
            CopiedCards[3] = Instantiate(OriginalCards[5], Slots[3].parent);
        }
        // Slot #5
        if (PlayerPrefs.GetInt("Value4") <= 55 && PlayerPrefs.GetInt("Value4") >= 50)//SuperStar
        {
            CopiedCards[4] = Instantiate(OriginalCards[0], Slots[4].parent);
        }
        if (PlayerPrefs.GetInt("Value4") <= 49 && PlayerPrefs.GetInt("Value4") >= 40)//AllStar
        {
            CopiedCards[4] = Instantiate(OriginalCards[1], Slots[4].parent);
        }
        if (PlayerPrefs.GetInt("Value4") <= 39 && PlayerPrefs.GetInt("Value4") >= 30)//Roleplayer
        {
            CopiedCards[4] = Instantiate(OriginalCards[2], Slots[4].parent);
        }
        if (PlayerPrefs.GetInt("Value4") <= 29 && PlayerPrefs.GetInt("Value4") >= 20)//Roleplayer2
        {
            CopiedCards[4] = Instantiate(OriginalCards[3], Slots[4].parent);
        }
        if (PlayerPrefs.GetInt("Value4") <= 19 && PlayerPrefs.GetInt("Value4") >= 10)//Roleplayer3
        {
            CopiedCards[4] = Instantiate(OriginalCards[4], Slots[4].parent);
        }
        if (PlayerPrefs.GetInt("Value4") <= 9 && PlayerPrefs.GetInt("Value4") >= 1)//BenchWarmer
        {
            CopiedCards[4] = Instantiate(OriginalCards[5], Slots[4].parent);
        }

    }

    public void ScoreSlotValue()
    {
        ScoreSlot0.text = PlayerPrefs.GetInt("Value0").ToString();
        ScoreSlot1.text = PlayerPrefs.GetInt("Value1").ToString();
        ScoreSlot2.text = PlayerPrefs.GetInt("Value2").ToString();
        ScoreSlot3.text = PlayerPrefs.GetInt("Value3").ToString();
        ScoreSlot4.text = PlayerPrefs.GetInt("Value4").ToString();
    }
}
