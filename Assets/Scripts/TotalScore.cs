using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TotalScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Player1Score;
    // Start is called before the first frame update
    private int Score;
    void Start()
    {
        ScoreSum();
    }

    void ScoreSum ()
    {
        Score = PlayerPrefs.GetInt("Value1") + PlayerPrefs.GetInt("Value2")+ PlayerPrefs.GetInt("Value3")
            + PlayerPrefs.GetInt("Value4")+ PlayerPrefs.GetInt("Value5");
        Player1Score.text = Score.ToString();
    }
}
