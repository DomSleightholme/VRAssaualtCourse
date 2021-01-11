using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testinglevel : MonoBehaviour
{
    public void OnLevel()
    {
        SceneManager.LoadScene("LoadingScreen");
    }
}
