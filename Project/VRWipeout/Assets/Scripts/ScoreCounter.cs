using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [Header("Score Factors")]
    public int FinalResultMinutes;
    public int FinalResultSeconds;

    [Header("Challenges")]
    public bool Challenge1Complete;
    public bool Challenge2Complete;
    public bool Challenge3Complete;

    [Header("Transforms")]
    public GameObject EndMenu;

    private int Level1Minutes;
    private int Level2Minutes;
    private int Level3Minutes;
    private int Level4Minutes;

    private void Start()
    {
        Level1Minutes = PlayerPrefs.GetInt("Level1Minutes");
        Level2Minutes = PlayerPrefs.GetInt("Level2Minutes");
        Level3Minutes = PlayerPrefs.GetInt("Level3Minutes");
        Level4Minutes = PlayerPrefs.GetInt("Level4Minutes");
    }

    public void LevelComplete()
    {
        //Check times and scores
        CheckTimes();
        CheckChallenges();

        var levelManager = FindObjectOfType<LevelManager>();
        levelManager.LevelRunning = false;
    }

    private void CheckTimes()
    {
        var levelTimer = FindObjectOfType<LevelTimer>();
        FinalResultMinutes = levelTimer.minutes;
        FinalResultSeconds = levelTimer.seconds;

        //Gets the scene index to check which level the player is on
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex == 2 && FinalResultMinutes < Level1Minutes || Level1Minutes == 0)
        {
            PlayerPrefs.SetInt("Level1Minutes", FinalResultMinutes);
            PlayerPrefs.SetInt("Level1Seconds", FinalResultSeconds);
        }
        if (sceneIndex == 3 && FinalResultMinutes < Level2Minutes || Level2Minutes == 0)
        {
            PlayerPrefs.SetInt("Level2Minutes", FinalResultMinutes);
            PlayerPrefs.SetInt("Level2Seconds", FinalResultSeconds);
        }
        if (sceneIndex == 4 && FinalResultMinutes < Level3Minutes || Level3Minutes == 0)
        {
            PlayerPrefs.SetInt("Level3Minutes", FinalResultMinutes);
            PlayerPrefs.SetInt("Level3Seconds", FinalResultSeconds);
        }
        if (sceneIndex == 5 && FinalResultMinutes < Level4Minutes || Level4Minutes == 0)
        {
            PlayerPrefs.SetInt("Level4Minutes", FinalResultMinutes);
            PlayerPrefs.SetInt("Level4Seconds", FinalResultSeconds);
        }
    }

    private void CheckChallenges()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        //Level 1
        if(sceneIndex == 2 && Challenge1Complete)
        {
            PlayerPrefs.SetInt("Level1Challenge1", 1);
        }
        if (sceneIndex == 2 && Challenge2Complete)
        {
            PlayerPrefs.SetInt("Level1Challenge2", 1);
        }
        if (sceneIndex == 2 && Challenge3Complete)
        {
            PlayerPrefs.SetInt("Level1Challenge3", 1);
        }

        //Level 2
        if (sceneIndex == 3 && Challenge1Complete)
        {
            PlayerPrefs.SetInt("Level2Challenge1", 1);
        }
        if (sceneIndex == 3 && Challenge2Complete)
        {
            PlayerPrefs.SetInt("Level2Challenge2", 1);
        }
        if (sceneIndex == 3 && Challenge3Complete)
        {
            PlayerPrefs.SetInt("Level2Challenge3", 1);
        }

        //Level 3
        if (sceneIndex == 4 && Challenge1Complete)
        {
            PlayerPrefs.SetInt("Level3Challenge1", 1);
        }
        if (sceneIndex == 4 && Challenge2Complete)
        {
            PlayerPrefs.SetInt("Level3Challenge2", 1);
        }
        if (sceneIndex == 4 && Challenge3Complete)
        {
            PlayerPrefs.SetInt("Level3Challenge3", 1);
        }

        //Level 4
        if (sceneIndex == 5 && Challenge1Complete)
        {
            PlayerPrefs.SetInt("Level4Challenge1", 1);
        }
        if (sceneIndex == 5 && Challenge2Complete)
        {
            PlayerPrefs.SetInt("Level4Challenge2", 1);
        }
        if (sceneIndex == 5 && Challenge3Complete)
        {
            PlayerPrefs.SetInt("Level4Challenge3", 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LevelComplete();

            GameObject menuParent = GameObject.Find("VR Rig/Camera Offset/PlayerUI");
            Vector3 pos = menuParent.transform.position;
            pos.y += 1;
            pos.z += 1;

            var GUI = Instantiate(EndMenu, pos, Quaternion.identity);
            GUI.transform.parent = menuParent.transform;
        }
    }
}
