using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class MultiplayerMenuController : MonoBehaviourPunCallbacks
{
    [Header("Game Objects")]
    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private TMP_Text Connection;
    [SerializeField] private TMP_Text Connection2;
    [SerializeField] private GameObject NextButton;
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject StartButton;

    [Header("Input Fields")]
    [SerializeField] private TMP_InputField UsernameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;

    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(default);
        Debug.Log("Connected");
    }

    public void Update()
    {
        ChangeUserNameInput();
    }

    public void ChangeUserNameInput()
    {
        if(UsernameInput.text.Length >= 3 && PhotonNetwork.IsConnectedAndReady)
        {
            StartButton.SetActive(true);
        }
        else
        {
            StartButton.SetActive(false);
        }
    }

    public void SetUserName()
    {
        UsernameMenu.SetActive(false);
        PhotonNetwork.LocalPlayer.NickName = UsernameInput.name;
        Debug.Log(UsernameInput.text);
    }

    public void CreateGame()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.CreateRoom(CreateGameInput.text, new Photon.Realtime.RoomOptions() { MaxPlayers = 4 }, null);

            mulitplayerManager manager = FindObjectOfType<mulitplayerManager>();
            manager.Roomcode = CreateGameInput.text;
            manager.Username = UsernameInput.text;
        }
    }
    public void JoinGame()
    {
        if (PhotonNetwork.IsConnected)
        {
            Photon.Realtime.RoomOptions roomOptions = new Photon.Realtime.RoomOptions
            {
                MaxPlayers = 4
            };
            PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions, default);

            mulitplayerManager manager = FindObjectOfType<mulitplayerManager>();
            manager.Roomcode = JoinGameInput.text;
            manager.Username = UsernameInput.text;
        }
    }

    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.LoadLevel("Multiplayer");
        }
    }
}
