using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [Header("Checkpoint Spawn")]
    public Transform SpawnCheckpoint;

    public void PlayerRespawn()
    {
        var levelManager = FindObjectOfType<LevelManager>();
        levelManager.PausedGame();
        GameObject Player = GameObject.FindGameObjectWithTag("Player");

        //Spawn at Checkpoint
        levelManager.LevelCountdown.SetTrigger("Start");
        Player.transform.position = SpawnCheckpoint.position;

        //Add respawn
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            var levelStats = FindObjectOfType<LevelOne>();
            levelStats.RespawnAmount += 1;
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            var levelStats = FindObjectOfType<LevelThree>();
            levelStats.RespawnAmount += 1;
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            var levelStats = FindObjectOfType<LevelFour>();
            levelStats.RespawnAmount += 1;
        }
    }
}
