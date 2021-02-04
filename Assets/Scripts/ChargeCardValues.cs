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
    public TextMeshProUGUI ScoreSlot5;
    public TextMeshProUGUI ScoreSlot6;
    public TextMeshProUGUI ScoreSlot7;
    public TextMeshProUGUI ScoreSlot8;
    public TextMeshProUGUI ScoreSlot9;
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
        int ValueScoreSlot0 = PlayerPrefs.GetInt("Value0");
        ScoreSlot1.text = PlayerPrefs.GetInt("Value1").ToString();
        int ValueScoreSlot1 = PlayerPrefs.GetInt("Value1");
        ScoreSlot2.text = PlayerPrefs.GetInt("Value2").ToString();
        int ValueScoreSlot2 = PlayerPrefs.GetInt("Value2");
        ScoreSlot3.text = PlayerPrefs.GetInt("Value3").ToString();
        int ValueScoreSlot3 = PlayerPrefs.GetInt("Value3");
        ScoreSlot4.text = PlayerPrefs.GetInt("Value4").ToString();
        int ValueScoreSlot4 = PlayerPrefs.GetInt("Value4");
        // Slot 5 CPU 1
        if (ValueScoreSlot0 <= 55 && ValueScoreSlot0 >= 40) 
        {
            int ValueScoreSlot5 = Random.Range(40, 56);
            ScoreSlot5.text = ValueScoreSlot5.ToString();
            if (ValueScoreSlot5 <= 55 && ValueScoreSlot5 >= 50) //SuperStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[0], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 49 && ValueScoreSlot5 >= 40) //AllStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[1], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 39 && ValueScoreSlot5 >= 30) //RolePlayer
            {
                CopiedCards[5] = Instantiate(OriginalCards[2], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 29 && ValueScoreSlot5 >= 20) //RolePlayer2
            {
                CopiedCards[5] = Instantiate(OriginalCards[3], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 19 && ValueScoreSlot5 >= 10) //RolePlayer3
            {
                CopiedCards[5] = Instantiate(OriginalCards[4], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 9 && ValueScoreSlot5 >= 1) //Benchwarmer
            {
                CopiedCards[5] = Instantiate(OriginalCards[5], Slots[5].parent);
            }
        }
        if (ValueScoreSlot0 <= 39 && ValueScoreSlot0 >= 20)
        {
            int ValueScoreSlot5 = Random.Range(10, 50);
            ScoreSlot5.text = ValueScoreSlot5.ToString();
            if (ValueScoreSlot5 <= 55 && ValueScoreSlot5 >= 50) //SuperStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[0], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 49 && ValueScoreSlot5 >= 40) //AllStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[1], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 39 && ValueScoreSlot5 >= 30) //RolePlayer
            {
                CopiedCards[5] = Instantiate(OriginalCards[2], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 29 && ValueScoreSlot5 >= 20) //RolePlayer2
            {
                CopiedCards[5] = Instantiate(OriginalCards[3], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 19 && ValueScoreSlot5 >= 10) //RolePlayer3
            {
                CopiedCards[5] = Instantiate(OriginalCards[4], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 9 && ValueScoreSlot5 >= 1) //Benchwarmer
            {
                CopiedCards[5] = Instantiate(OriginalCards[5], Slots[5].parent);
            }
        }
        if (ValueScoreSlot0 <= 19 && ValueScoreSlot0 >= 1)
        {
            int ValueScoreSlot5 = Random.Range(10, 40);
            ScoreSlot5.text = ValueScoreSlot5.ToString();
            if (ValueScoreSlot5 <= 55 && ValueScoreSlot5 >= 50) //SuperStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[0], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 49 && ValueScoreSlot5 >= 40) //AllStar
            {
                CopiedCards[5] = Instantiate(OriginalCards[1], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 39 && ValueScoreSlot5 >= 30) //RolePlayer
            {
                CopiedCards[5] = Instantiate(OriginalCards[2], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 29 && ValueScoreSlot5 >= 20) //RolePlayer2
            {
                CopiedCards[5] = Instantiate(OriginalCards[3], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 19 && ValueScoreSlot5 >= 10) //RolePlayer3
            {
                CopiedCards[5] = Instantiate(OriginalCards[4], Slots[5].parent);
            }
            if (ValueScoreSlot5 <= 9 && ValueScoreSlot5 >= 1) //Benchwarmer
            {
                CopiedCards[5] = Instantiate(OriginalCards[5], Slots[5].parent);
            }
        }
        // Slot 6 CPU 2
        if (ValueScoreSlot1 <= 55 && ValueScoreSlot1 >= 40)
        {
            int ValueScoreSlot6 = Random.Range(40, 56);
            ScoreSlot6.text = ValueScoreSlot6.ToString();
            if (ValueScoreSlot6 <= 55 && ValueScoreSlot6 >= 50) //SuperStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[0], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 49 && ValueScoreSlot6 >= 40) //AllStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[1], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 39 && ValueScoreSlot6 >= 30) //RolePlayer
            {
                CopiedCards[6] = Instantiate(OriginalCards[2], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 29 && ValueScoreSlot6 >= 20) //RolePlayer2
            {
                CopiedCards[6] = Instantiate(OriginalCards[3], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 19 && ValueScoreSlot6 >= 10) //RolePlayer3
            {
                CopiedCards[6] = Instantiate(OriginalCards[4], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 9 && ValueScoreSlot6 >= 1) //Benchwarmer
            {
                CopiedCards[6] = Instantiate(OriginalCards[5], Slots[6].parent);
            }
        }
        if (ValueScoreSlot1 <= 39 && ValueScoreSlot1 >= 20)
        {
            int ValueScoreSlot6 = Random.Range(10, 49);
            ScoreSlot6.text = ValueScoreSlot6.ToString();
            if (ValueScoreSlot6 <= 55 && ValueScoreSlot6 >= 50) //SuperStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[0], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 49 && ValueScoreSlot6 >= 40) //AllStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[1], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 39 && ValueScoreSlot6 >= 30) //RolePlayer
            {
                CopiedCards[6] = Instantiate(OriginalCards[2], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 29 && ValueScoreSlot6 >= 20) //RolePlayer2
            {
                CopiedCards[6] = Instantiate(OriginalCards[3], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 19 && ValueScoreSlot6 >= 10) //RolePlayer3
            {
                CopiedCards[6] = Instantiate(OriginalCards[4], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 9 && ValueScoreSlot6 >= 1) //Benchwarmer
            {
                CopiedCards[6] = Instantiate(OriginalCards[5], Slots[6].parent);
            }
        }
        if (ValueScoreSlot1 <= 19 && ValueScoreSlot1 >= 1)
        {
            int ValueScoreSlot6 = Random.Range(10, 39);
            ScoreSlot6.text = ValueScoreSlot6.ToString();
            if (ValueScoreSlot6 <= 55 && ValueScoreSlot6 >= 50) //SuperStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[0], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 49 && ValueScoreSlot6 >= 40) //AllStar
            {
                CopiedCards[6] = Instantiate(OriginalCards[1], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 39 && ValueScoreSlot6 >= 30) //RolePlayer
            {
                CopiedCards[6] = Instantiate(OriginalCards[2], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 29 && ValueScoreSlot6 >= 20) //RolePlayer2
            {
                CopiedCards[6] = Instantiate(OriginalCards[3], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 19 && ValueScoreSlot6 >= 10) //RolePlayer3
            {
                CopiedCards[6] = Instantiate(OriginalCards[4], Slots[6].parent);
            }
            if (ValueScoreSlot6 <= 9 && ValueScoreSlot6 >= 1) //Benchwarmer
            {
                CopiedCards[6] = Instantiate(OriginalCards[5], Slots[6].parent);
            }
        }
        // Slot 7 CPU 3
        if (ValueScoreSlot2 <= 55 && ValueScoreSlot2 >= 40)
        {
            int ValueScoreSlot7 = Random.Range(40, 56);
            ScoreSlot7.text = ValueScoreSlot7.ToString();
            if (ValueScoreSlot7 <= 55 && ValueScoreSlot7 >= 50) //SuperStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[0], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 49 && ValueScoreSlot7 >= 40) //AllStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[1], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 39 && ValueScoreSlot7 >= 30) //RolePlayer
            {
                CopiedCards[7] = Instantiate(OriginalCards[2], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 29 && ValueScoreSlot7 >= 20) //RolePlayer2
            {
                CopiedCards[7] = Instantiate(OriginalCards[3], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 19 && ValueScoreSlot7 >= 10) //RolePlayer3
            {
                CopiedCards[7] = Instantiate(OriginalCards[4], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 9 && ValueScoreSlot7 >= 1) //Benchwarmer
            {
                CopiedCards[7] = Instantiate(OriginalCards[5], Slots[7].parent);
            }
        }
        if (ValueScoreSlot2 <= 39 && ValueScoreSlot2 >= 20)
        {
            int ValueScoreSlot7 = Random.Range(10, 49);
            ScoreSlot7.text = ValueScoreSlot7.ToString();
            if (ValueScoreSlot7 <= 55 && ValueScoreSlot7 >= 50) //SuperStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[0], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 49 && ValueScoreSlot7 >= 40) //AllStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[1], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 39 && ValueScoreSlot7 >= 30) //RolePlayer
            {
                CopiedCards[7] = Instantiate(OriginalCards[2], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 29 && ValueScoreSlot7 >= 20) //RolePlayer2
            {
                CopiedCards[7] = Instantiate(OriginalCards[3], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 19 && ValueScoreSlot7 >= 10) //RolePlayer3
            {
                CopiedCards[7] = Instantiate(OriginalCards[4], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 9 && ValueScoreSlot7 >= 1) //Benchwarmer
            {
                CopiedCards[7] = Instantiate(OriginalCards[5], Slots[7].parent);
            }
        }
        if (ValueScoreSlot2 <= 19 && ValueScoreSlot2 >= 1)
        {
            int ValueScoreSlot7 = Random.Range(10, 39);
            ScoreSlot7.text = ValueScoreSlot7.ToString();
            if (ValueScoreSlot7 <= 55 && ValueScoreSlot7 >= 50) //SuperStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[0], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 49 && ValueScoreSlot7 >= 40) //AllStar
            {
                CopiedCards[7] = Instantiate(OriginalCards[1], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 39 && ValueScoreSlot7 >= 30) //RolePlayer
            {
                CopiedCards[7] = Instantiate(OriginalCards[2], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 29 && ValueScoreSlot7 >= 20) //RolePlayer2
            {
                CopiedCards[7] = Instantiate(OriginalCards[3], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 19 && ValueScoreSlot7 >= 10) //RolePlayer3
            {
                CopiedCards[7] = Instantiate(OriginalCards[4], Slots[7].parent);
            }
            if (ValueScoreSlot7 <= 9 && ValueScoreSlot7 >= 1) //Benchwarmer
            {
                CopiedCards[7] = Instantiate(OriginalCards[5], Slots[7].parent);
            }
        }
        // Slot 8 CPU 4
        if (ValueScoreSlot3 <= 55 && ValueScoreSlot3 >= 40)
        {
            int ValueScoreSlot8 = Random.Range(40, 56);
            ScoreSlot8.text = ValueScoreSlot8.ToString();
            if (ValueScoreSlot8 <= 55 && ValueScoreSlot8 >= 50) //SuperStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[0], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 49 && ValueScoreSlot8 >= 40) //AllStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[1], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 39 && ValueScoreSlot8 >= 30) //RolePlayer
            {
                CopiedCards[8] = Instantiate(OriginalCards[2], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 29 && ValueScoreSlot8 >= 20) //RolePlayer2
            {
                CopiedCards[8] = Instantiate(OriginalCards[3], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 19 && ValueScoreSlot8 >= 10) //RolePlayer3
            {
                CopiedCards[8] = Instantiate(OriginalCards[4], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 9 && ValueScoreSlot8 >= 1) //Benchwarmer
            {
                CopiedCards[8] = Instantiate(OriginalCards[5], Slots[8].parent);
            }
        }
        if (ValueScoreSlot3 <= 39 && ValueScoreSlot3 >= 20)
        {
            int ValueScoreSlot8 = Random.Range(10, 49);
            ScoreSlot8.text = ValueScoreSlot8.ToString();
            if (ValueScoreSlot8 <= 55 && ValueScoreSlot8 >= 50) //SuperStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[0], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 49 && ValueScoreSlot8 >= 40) //AllStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[1], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 39 && ValueScoreSlot8 >= 30) //RolePlayer
            {
                CopiedCards[8] = Instantiate(OriginalCards[2], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 29 && ValueScoreSlot8 >= 20) //RolePlayer2
            {
                CopiedCards[8] = Instantiate(OriginalCards[3], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 19 && ValueScoreSlot8 >= 10) //RolePlayer3
            {
                CopiedCards[8] = Instantiate(OriginalCards[4], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 9 && ValueScoreSlot8 >= 1) //Benchwarmer
            {
                CopiedCards[8] = Instantiate(OriginalCards[5], Slots[8].parent);
            }
        }
        if (ValueScoreSlot3 <= 19 && ValueScoreSlot3 >= 1)
        {
            int ValueScoreSlot8 = Random.Range(10, 39);
            ScoreSlot8.text = ValueScoreSlot8.ToString();
            if (ValueScoreSlot8 <= 55 && ValueScoreSlot8 >= 50) //SuperStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[0], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 49 && ValueScoreSlot8 >= 40) //AllStar
            {
                CopiedCards[8] = Instantiate(OriginalCards[1], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 39 && ValueScoreSlot8 >= 30) //RolePlayer
            {
                CopiedCards[8] = Instantiate(OriginalCards[2], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 29 && ValueScoreSlot8 >= 20) //RolePlayer2
            {
                CopiedCards[8] = Instantiate(OriginalCards[3], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 19 && ValueScoreSlot8 >= 10) //RolePlayer3
            {
                CopiedCards[8] = Instantiate(OriginalCards[4], Slots[8].parent);
            }
            if (ValueScoreSlot8 <= 9 && ValueScoreSlot8 >= 1) //Benchwarmer
            {
                CopiedCards[8] = Instantiate(OriginalCards[5], Slots[8].parent);
            }
        }
        // Slot 9 CPU 5
        if (ValueScoreSlot4 <= 55 && ValueScoreSlot4 >= 40)
        {
            int ValueScoreSlot9 = Random.Range(40, 56);
            ScoreSlot9.text = ValueScoreSlot9.ToString();
            if (ValueScoreSlot9 <= 55 && ValueScoreSlot9 >= 50) //SuperStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[0], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 49 && ValueScoreSlot9 >= 40) //AllStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[1], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 39 && ValueScoreSlot9 >= 30) //RolePlayer
            {
                CopiedCards[9] = Instantiate(OriginalCards[2], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 29 && ValueScoreSlot9 >= 20) //RolePlayer2
            {
                CopiedCards[9] = Instantiate(OriginalCards[3], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 19 && ValueScoreSlot9 >= 10) //RolePlayer3
            {
                CopiedCards[9] = Instantiate(OriginalCards[4], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 9 && ValueScoreSlot9 >= 1) //Benchwarmer
            {
                CopiedCards[9] = Instantiate(OriginalCards[5], Slots[9].parent);
            }
        }
        if (ValueScoreSlot4 <= 39 && ValueScoreSlot4 >= 20)
        {
            int ValueScoreSlot9 = Random.Range(10, 49);
            ScoreSlot9.text = ValueScoreSlot9.ToString();
            if (ValueScoreSlot9 <= 55 && ValueScoreSlot9 >= 50) //SuperStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[0], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 49 && ValueScoreSlot9 >= 40) //AllStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[1], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 39 && ValueScoreSlot9 >= 30) //RolePlayer
            {
                CopiedCards[9] = Instantiate(OriginalCards[2], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 29 && ValueScoreSlot9 >= 20) //RolePlayer2
            {
                CopiedCards[9] = Instantiate(OriginalCards[3], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 19 && ValueScoreSlot9 >= 10) //RolePlayer3
            {
                CopiedCards[9] = Instantiate(OriginalCards[4], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 9 && ValueScoreSlot9 >= 1) //Benchwarmer
            {
                CopiedCards[9] = Instantiate(OriginalCards[5], Slots[9].parent);
            }
        }
        if (ValueScoreSlot4 <= 19 && ValueScoreSlot4 >= 1)
        {
            int ValueScoreSlot9 = Random.Range(10, 39);
            ScoreSlot9.text = ValueScoreSlot9.ToString();
            if (ValueScoreSlot9 <= 55 && ValueScoreSlot9 >= 50) //SuperStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[0], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 49 && ValueScoreSlot9 >= 40) //AllStar
            {
                CopiedCards[9] = Instantiate(OriginalCards[1], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 39 && ValueScoreSlot9 >= 30) //RolePlayer
            {
                CopiedCards[9] = Instantiate(OriginalCards[2], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 29 && ValueScoreSlot9 >= 20) //RolePlayer2
            {
                CopiedCards[9] = Instantiate(OriginalCards[3], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 19 && ValueScoreSlot9 >= 10) //RolePlayer3
            {
                CopiedCards[9] = Instantiate(OriginalCards[4], Slots[9].parent);
            }
            if (ValueScoreSlot9 <= 9 && ValueScoreSlot9 >= 1) //Benchwarmer
            {
                CopiedCards[9] = Instantiate(OriginalCards[5], Slots[9].parent);
            }
        }
    }
}
