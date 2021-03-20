using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeAudio : MonoBehaviour
{
    public Slider sliderMusic;
    public Slider sliderEffects;

    private void Awake()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("volume");
        sliderEffects.value = PlayerPrefs.GetFloat("effectsvolume");
    }
    public void Update()
    {
        PlayerPrefs.SetFloat("volume", sliderMusic.value);
        PlayerPrefs.SetFloat("effectsvolume", sliderEffects.value);
    }
}
