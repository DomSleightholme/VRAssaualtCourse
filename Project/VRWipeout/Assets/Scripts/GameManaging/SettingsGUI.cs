using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsGUI : MonoBehaviour
{
    [Header("Preferences")]
    public Slider TurnAngleSlider;
    public TMP_Text TurnAngleValueText;
    public float TurnAngleValue;
    private string CameraVignetteColor;

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
    public string OutlineColor;

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

    private void Update()
    {
        int turnText = (int)TurnAngleValue;

        TurnAngleValueText.text = turnText.ToString();
        GUIMenuDistanceText.text = GUIMenuDistance.ToString();
        GUIMenuHeightText.text = GUIMenuHeight.ToString();

        getData();
        saveData();
    }

    //Get Player Prefs Data
    private void getData()
    {
        TurnAngleValue = PlayerPrefs.GetFloat("TurnAngleValue");

        GUIMenuDistance = PlayerPrefs.GetInt("GUIMenuDistance");
        GUIMenuHeight = PlayerPrefs.GetInt("GUIMenuHeight");
        GraphicsIndex = PlayerPrefs.GetInt("GraphicsIndex");

        CameraVignetteColor = PlayerPrefs.GetString("CameraVignetteColor");
        OutlineColor = PlayerPrefs.GetString("OutlineColor");

        //Bool
        int postProcessing = PlayerPrefs.GetInt("PostProcessing");
        if(postProcessing == 0)
        {
            PostProcessing = false;
        }
        else
        {
            PostProcessing = true;
        }

        int realCrouch = PlayerPrefs.GetInt("RealCrouch");
        if(realCrouch == 0)
        {
            RealCouch = false;
        }
        else
        {
            RealCouch = true;
        }

        int gamepad = PlayerPrefs.GetInt("Gamepad");
        if(gamepad == 0)
        {
            Gamepad = false;
        }
        else
        {
            Gamepad = true;
        }
    }

    //Save to Player Prefs
    private void saveData()
    {
        //Float
        PlayerPrefs.SetFloat("TurnAngleValue", TurnAngleValue);

        //Int
        PlayerPrefs.SetInt("GUIMenuDistance", GUIMenuDistance);
        PlayerPrefs.SetInt("GUIMenuHeight", GUIMenuHeight);
        PlayerPrefs.SetInt("GraphicsIndex", GraphicsIndex);

        //String
        PlayerPrefs.SetString("CameraVignetteColor", CameraVignetteColor);
        PlayerPrefs.SetString("OutlineColor", OutlineColor);

        //Bool
        if (RealCouch)
        {
            PlayerPrefs.SetInt("RealCrouch", 1);
        }
        else
        {
            PlayerPrefs.SetInt("RealCrouch", 1);
        }

        if (Gamepad)
        {
            PlayerPrefs.SetInt("Gamepad", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Gamepad", 0);
        }

        if (PostProcessing)
        {
            PlayerPrefs.SetInt("PostProcessing", 1);
        }
        else
        {
            PlayerPrefs.SetInt("PostProcessing", 0);
        }
    }

    //Get Music Volume
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

    //Set Settings Functions
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
        OutlineColor = ColorText;
    }
    public void setCamColor(string ColorText)
    {
        CameraVignetteColor = ColorText;
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
