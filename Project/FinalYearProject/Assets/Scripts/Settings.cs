using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;

    public Slider MusicSlider;
    public Slider SFXSlider;

    float music;
    float sfx;

    private void Start()
    {
        StartMusic();
        StartSFX();

        SFXSlider.value = sfx;
        MusicSlider.value = music;
    }

    private float StartMusic()
    {
        //Gets the volume from the Music Mixer
        bool musicResult = MusicMixer.GetFloat("MusicVolume", out music);

        if (musicResult)
        {
            return music;
        }
        else
        {
            return 0f;
        }
    }

    private float StartSFX()
    {
        //Gets the volume from the Music Mixer
        bool sfxResult = SFXMixer.GetFloat("SFXVolume", out sfx);
        if (sfxResult)
        {
            return sfx;
        }
        else
        {
            return 0;
        }
    }

    public void SetMusicVolume(float volume)
    {
        MusicMixer.SetFloat("MusicVolume", volume);
    }

    public void SetSFXVolume(float volume)
    {
        SFXMixer.SetFloat("SFXVolume", volume);
    }
}
