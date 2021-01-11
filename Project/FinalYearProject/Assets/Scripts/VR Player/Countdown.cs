using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [Header("Animator")]
    public Animator CountdownAnimator;

    [Header("Object")]
    public GameObject CountdownObject;
    public Image CountdownImage;

    public bool isPlaying;

    private LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        //Start the Countdown as beginning of the scene
        CountdownObject.SetActive(true);
        CountdownImage.enabled = true;
        CountdownAnimator.SetTrigger("Countdown");

        isPlaying = true;
    }

    private void Update()
    {
        if(CountdownAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            EndCount();
            isPlaying = false;
        }
    }

    public void StartCountdown()
    {
        CountdownAnimator.SetBool("Reset", true);
        CountdownAnimator.SetTrigger("Countdown");
        isPlaying = true;
    }

    void EndCount()
    {
        if (CountdownImage.IsActive())
        {
            levelManager.PausedGame();
        }
        else
        {
            levelManager.StartLevel();
        }
    }
}
