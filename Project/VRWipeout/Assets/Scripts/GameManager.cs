using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public string nextScene;
    void Awake()
    {
        //Keeps the instance of the gameobject between scenes
        DontDestroyOnLoad(this);

        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
        nextScene = scene;
    }
}
