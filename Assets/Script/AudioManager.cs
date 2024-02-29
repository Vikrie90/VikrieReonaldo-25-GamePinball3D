using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgmAudioSource;
    public GameObject sfxAudioBumper;
    public GameObject sfxAudioSwitch;

    void Start()
    {
        PlayBGM();   
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioBumper, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSwitch, spawnPosition, Quaternion.identity);
    }
}
