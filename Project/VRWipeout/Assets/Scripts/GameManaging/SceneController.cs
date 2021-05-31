using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    public string nextScene;

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
        nextScene = scene;

        PlayerPrefs.SetString("LevelName", scene);
    }
}
