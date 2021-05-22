using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [Header("Preferences")]
    public float TurnAngleValue;
    public Color CameraVignette;

    [Header("Interface")]
    public int GUIMenuDistance;
    public int GUIMenuHeight;

    [Header("Graphics")]
    public bool PostProcessing;
    public int GraphicsIndex;

    [Header("Accessibility")]
    public bool RealCrouch;
    public bool Gamepad;
    public Color OutlineColor;

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

    private void Update()
    {
        getData();
    }

    private void getData()
    {
        //Color
        setColor();

        //Float
        TurnAngleValue = PlayerPrefs.GetFloat("TurnAngleValue");

        //Int
        GUIMenuDistance = PlayerPrefs.GetInt("GUIMenuDistance");
        GUIMenuHeight = PlayerPrefs.GetInt("GUIMenuHeight");
        GraphicsIndex = PlayerPrefs.GetInt("GraphicsIndex");

        //Bool
        int postProcessing = PlayerPrefs.GetInt("PostProcessing");
        if (postProcessing == 0)
        {
            PostProcessing = false;
        }
        else
        {
            PostProcessing = true;
        }

        int realCrouch = PlayerPrefs.GetInt("RealCrouch");
        if (realCrouch == 0)
        {
            RealCrouch = false;
        }
        else
        {
            RealCrouch = true;
        }

        int gamepad = PlayerPrefs.GetInt("Gamepad");
        if (gamepad == 0)
        {
            Gamepad = false;
        }
        else
        {
            Gamepad = true;
        }
    }

    private void setColor()
    {
        //Outline Color
        string outlineColor = PlayerPrefs.GetString("OutlineColor");
        if(outlineColor == "Red")
        {
            OutlineColor = Color.red;
        }
        if (outlineColor == "Blue")
        {
            OutlineColor = Color.blue;
        }
        if (outlineColor == "Green")
        {
            OutlineColor = Color.green;
        }
        if (outlineColor == "Yellow")
        {
            OutlineColor = Color.yellow;
        }
        if (outlineColor == "White")
        {
            OutlineColor = Color.white;
        }
        if (outlineColor == "Black")
        {
            OutlineColor = Color.black;
        }

        //Vignette Color
        string vignetteColor = PlayerPrefs.GetString("CameraVignetteColor");
        if (vignetteColor == "Red")
        {
            CameraVignette = Color.red;
        }
        if (vignetteColor == "Blue")
        {
            CameraVignette = Color.blue;
        }
        if (vignetteColor == "Green")
        {
            CameraVignette = Color.green;
        }
        if (vignetteColor == "Yellow")
        {
            CameraVignette = Color.yellow;
        }
        if (vignetteColor == "White")
        {
            CameraVignette = Color.white;
        }
        if (vignetteColor == "Black")
        {
            CameraVignette = Color.black;
        }
    }
}
