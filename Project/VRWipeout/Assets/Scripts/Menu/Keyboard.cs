using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    [Header("Variables")]
    public TMP_InputField inputField;
    public bool capsLock;

    [Header("Lists")]
    public List<TMP_Text> letters;
    public List<GameObject> hideObjects;

    private void Start()
    {
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }

        capsLock = false;

        for (int i = 0; i < letters.Count; i++)
        {
            letters[i].fontStyle = FontStyles.LowerCase;
        }
    }


    public void Word(Button button)
    {
        string text = button.gameObject.GetComponentInChildren<TMP_Text>().text;

        if (capsLock)
        {
            inputField.text += text.ToUpper();
        }
        else
        {
            inputField.text += text.ToLower();
        }
    }

    public void backSpace()
    {
      string text = inputField.text;

      if(inputField.text.Length > 0)
      {
            inputField.text = text.Remove(text.Length - 1);
      }
    }
    public void CapsButton()
    {
        if (capsLock == false)
        {
            capsLock = true;

            for(int i = 0; i < letters.Count; i++)
            {
                letters[i].fontStyle = FontStyles.UpperCase;
            }
        }
        else
        {
            capsLock = false;

            for (int i = 0; i < letters.Count; i++)
            {
                letters[i].fontStyle = FontStyles.LowerCase;
            }
        }
    }
    public void Space()
    {
        inputField.text += " ";
    }

    public void Enter()
    {
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }

        for (int i = 0; i < hideObjects.Count; i++)
        {
            hideObjects[i].SetActive(true);
        }
    }

    public void openKeyboard()
    {
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(true);
        }

        for (int i = 0; i < hideObjects.Count; i++)
        {
            hideObjects[i].SetActive(false);
        }
    }
}
