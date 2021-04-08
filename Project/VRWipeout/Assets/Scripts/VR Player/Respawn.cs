using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public bool respawnMode;

    [Header("Checkpoint Name")]
    public string CurrentCheckpoint;

    [Header("Checkpoint Spawn")]
    public GameObject Checkpoint_1;
    public GameObject Checkpoint_2;
    public GameObject Checkpoint_3;
    public Transform SpawnCheckpoint;
    private GameObject Spawn;

    private void Start()
    {
        CurrentCheckpoint = "None";

        Checkpoint_1 = GameObject.Find("Checkpoint_1");
        Checkpoint_2 = GameObject.Find("Checkpoint_2");
        Checkpoint_3 = GameObject.Find("Checkpoint_3");
        Spawn = GameObject.Find("MainSpawn");
    }
    public void PlayerDeath() 
    {
        if (respawnMode)
        {
            PlayerRespawn();
        }
        else
        {
            LevelEnd();
        }
    }

    public void PlayerRespawn()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        
        //Spawn at Checkpoint
    }

    public void LevelEnd()
    {
        var levelmanager = FindObjectOfType<LevelManager>();
        levelmanager.LevelDeath();
    }
}
