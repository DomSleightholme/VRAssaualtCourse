using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class MultiplayerLevelManager : MonoBehaviour
{
    [Header("Text")]
    public TMP_Text Ping;
    public TMP_Text RoomName;

    private void Update()
    {
        Ping.text =  "Ping: " + PhotonNetwork.GetPing().ToString();

        mulitplayerManager mulitplayerManager = FindObjectOfType<mulitplayerManager>();
        RoomName.text = mulitplayerManager.Roomcode;
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel("MainMenu");
    }
}
