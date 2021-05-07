using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mulitplayerManager : MonoBehaviour
{
    public bool Created;
    public string Username;
    public string Roomcode;
    private void Awake()
    {
        if (!Created)
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
