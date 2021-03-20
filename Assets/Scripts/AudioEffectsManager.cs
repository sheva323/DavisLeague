using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffectsManager : MonoBehaviour
{
    public AudioSource[] SoundEffects;
    private void Awake()
    {
        for (int i = 0; i < SoundEffects.Length; i++)
        {
            SoundEffects[i].volume = PlayerPrefs.GetFloat("effectsvolume");
        }
    }
}
