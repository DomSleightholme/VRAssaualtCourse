using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    [Header("Preferences")]
    public Slider TurnAngleSlider;
    public TMP_Text TurnAngleValueText;
    public float TurnAngleValue;
    public Color CameraVignette;

    [Header("Interface")]
    public int GUIMenuDistance;
    public int GUIMenuHeight;
    public Slider GUIMenuDistanceSlider;
    public Slider GUIMenuHeightSlider;
    public TMP_Text GUIMenuDistanceText;
    public TMP_Text GUIMenuHeightText;

    [Header("Graphics")]
    public bool PostProcessing;
    public int GraphicsIndex;

    [Header("Accessibility")]
    public bool RealCouch;
    public bool Gamepad;
    public Color OutlineColor;

    [Header("Audio")]
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;
    public Slider MusicSlider;
    public Slider SFXSlider;

    float music;
    float sfx;

    private static Settings playerSettings;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerSettings == null)
        {
            playerSettings = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);

        //Audio
        StartMusic();
        StartSFX();

        SFXSlider.value = sfx;
        MusicSlider.value = music;
    }

    private void Update()
    {
        int turnText = (int)TurnAngleValue;

        TurnAngleValueText.text = turnText.ToString();
        GUIMenuDistanceText.text = GUIMenuDistance.ToString();
        GUIMenuHeightText.text = GUIMenuHeight.ToString();
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

    public void SetTurnAngle()
    {
       TurnAngleValue = TurnAngleSlider.value;
    }
    public void SetGUIHeight()
    {
        GUIMenuHeight = (int)GUIMenuHeightSlider.value;
    }
    public void setGUIDistance()
    {
        GUIMenuDistance = (int)GUIMenuDistanceSlider.value;
    }
    public void setGraphics(int index)
    {
        GraphicsIndex = index;
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }
    public void setOutlineColor(string ColorText)
    {
        if(ColorText == "Red")
        {
            OutlineColor = Color.red;
        }
        if(ColorText == "Blue")
        {
            OutlineColor = Color.blue;
        }
        if (ColorText == "Green")
        {
            OutlineColor = Color.green;
        }
        if(ColorText == "Yellow")
        {
            OutlineColor = Color.yellow;
        }
        if(ColorText == "White")
        {
            OutlineColor = Color.white;
        }
        if(ColorText == "Black")
        {
            OutlineColor = Color.black;
        }
    }
    public void setCamColor(string ColorText)
    {
        if (ColorText == "Red")
        {
            CameraVignette = Color.red;
        }
        if (ColorText == "Blue")
        {
            CameraVignette = Color.blue;
        }
        if (ColorText == "Green")
        {
            CameraVignette = Color.green;
        }
        if (ColorText == "Yellow")
        {
            CameraVignette = Color.yellow;
        }
        if (ColorText == "White")
        {
            CameraVignette = Color.white;
        }
        if (ColorText == "Black")
        {
            CameraVignette = Color.black;
        }
    }
    public void PostProcessingMode(bool PostP)
    {
        PostProcessing = PostP;    
    }
    public void RealCouchMode(bool mode)
    {
        RealCouch = mode;
    }
    public void ControllerMode(bool input)
    {
        Gamepad = input;
    }
    public void resetValues()
    {
        GUIMenuHeight = 0;
        GUIMenuDistance = 0;
        TurnAngleValue = 0;
        PostProcessing = true;
    }
}
