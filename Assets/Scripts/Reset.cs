using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public GameObject[] ToHide;
    public GameObject[] ToShow;


    public void ResetButton()
    {
        for (int i = 0; i<ToHide.Length; i++)
        {
            ToHide[i].SetActive(false);
        }
        for (int i = 0; i<ToShow.Length; i++)
        {
            ToShow[i].SetActive(true);
        }
    }
    public void NoButton()
    {
        for (int i = 0; i < ToHide.Length; i++)
        {
            ToHide[i].SetActive(true);
        }
        for (int i = 0; i < ToShow.Length; i++)
        {
            ToShow[i].SetActive(false);
        }
    }
    public void YesButton()
    {
        for (int i = 0; i < ToHide.Length; i++)
        {
            ToHide[i].SetActive(true);
        }
        for (int i = 0; i < ToShow.Length; i++)
        {
            ToShow[i].SetActive(false);
        }
    }
}
