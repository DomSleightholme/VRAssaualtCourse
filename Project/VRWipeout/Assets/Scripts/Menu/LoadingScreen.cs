using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [Header("Animator")]
    public Animator SceneTransitionAnimator;

    [Header("UI")]
    public List<string> Tips = new List<string>();
    public TMP_Text LevelTitleUI;
    public TMP_Text TipsUI;

    [Header("Next Level")]
    public string LevelTitle;
    public string LevelMode;
    public int SceneTimer;

    private void Awake()
    {
        var gameManager = FindObjectOfType<GameManager>();
        LevelTitle = gameManager.nextScene;
    }

    private void Start()
    {
        StartCoroutine(NextLevel());

        LevelTitleUI.text = LevelTitle;

        int randomNum = Random.Range(0, Tips.Count);
        TipsUI.text = Tips[randomNum];
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(SceneTimer - 1);
        SceneTransitionAnimator.SetTrigger("NextLevel");
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(LevelTitle);
    }
}
