using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [Header("Animator")]
    public Animator SceneTrans; 
    [Header("LoadingScreen")]
    public string Level;
    public int Timer;

    private void Start()
    {
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(Timer - 1);
        SceneTrans.SetTrigger("NextLevel");
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(Level);
    }
}
