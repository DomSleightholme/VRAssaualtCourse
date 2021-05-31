using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Token : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                var levelStats = FindObjectOfType<LevelThree>();
                levelStats.TokenAmount += 1;
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                var levelStats = FindObjectOfType<LevelFour>();
                levelStats.TokenCollection += 1;
            }

            Destroy(gameObject);
        }
    }
}
