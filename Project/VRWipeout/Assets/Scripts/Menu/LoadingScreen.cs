using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [Header("UI")]
    public List<string> Tips = new List<string>();
    public TMP_Text LevelTitleUI;
    public TMP_Text TipsUI;

    [Header("Next Level")]
    public string LevelTitle;
    public int SceneTimer;

    private void Awake()
    {
        LevelTitle = PlayerPrefs.GetString("LevelName");
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
        yield return new WaitForSeconds(SceneTimer);

        SceneManager.LoadScene(LevelTitle);
    }
}
