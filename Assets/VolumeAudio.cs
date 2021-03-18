using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeAudio : MonoBehaviour
{
    public Slider sliderMusic;

    private void Awake()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("volume");
    }
    public void Update()
    {
        PlayerPrefs.SetFloat("volume", sliderMusic.value);
    }
}
