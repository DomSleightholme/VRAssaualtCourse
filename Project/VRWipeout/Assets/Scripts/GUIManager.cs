using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    [Header("Variables")]
    public float GUIDistance;
    public float GUIHeight;

    [Header("Transforms")]
    public Transform Camera;    
    void Update()
    {
        getData();

        transform.localPosition = new Vector3(0, GUIHeight, GUIDistance);
    }

    void getData()
    {
        var settings = FindObjectOfType<Settings>();
        if(settings != null)
        {
            GUIDistance = settings.GUIMenuDistance;
            GUIHeight = settings.GUIMenuHeight;
        }
    }

    public void onGUIOpen()
    {
        transform.localEulerAngles = new Vector3(0, Camera.localEulerAngles.y, 0);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
