using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mulitplayerManager : MonoBehaviour
{
    public bool Created;
    public string Username;
    public string Roomcode;
    private void Awake()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (!Created && sceneIndex == 0 || sceneIndex == 6)
        {
            DontDestroyOnLoad(this.gameObject);
            Created = true;
        }
        else
        {
            Destroy(this);
        }
    }
}
