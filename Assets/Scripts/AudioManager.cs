using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject[] OriginalAudioSource;
    public AudioSource BackgroundAudio;

    private void Awake()
    {
        OriginalAudioSource = GameObject.FindGameObjectsWithTag("audiosource");
        if (OriginalAudioSource.Length > 1)
        {
            Destroy(OriginalAudioSource[1]);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(BackgroundAudio);
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundAudio.volume = PlayerPrefs.GetFloat("volume");
    }
}
