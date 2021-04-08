using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("Preferences")]
    public bool ContinuousTurnAngle;
    public float TurnAngleValue;
    public Color CameraVignette;
    public Color UIPointerColour;

    [Header("Interface")]
    public int GUIMenuDistance;
    public int GUIMenuHeight;

    [Header("Graphics")]
    public bool PostProcessing;
    public int GraphicsIndex;

    [Header("Accessibility")]
    public bool SeatedMode;
    public bool RealCouch;
    public enum ControllerInput { VRControllers, Gamepad };
    public ControllerInput controllerInput;

    [Header("Audio")]
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;
    public Slider MusicSlider;
    public Slider SFXSlider;

    float music;
    float sfx;

    private void Start()
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);

        //Audio
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
