using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Menu : MonoBehaviourPunCallbacks
{
    [Header("Screens")]
    public GameObject mainScreen;
    public GameObject lobbyScreen;
    [Header("Main Screen")]
    public Button createRoomButton;
    public Button joinRoomButton;
    [Header("Lobby Screen")]
    public Text playerListText;
    public Button startGameButton;

    public GameObject backButton;
    private void Start()
    {
        createRoomButton.interactable = false;
        joinRoomButton.interactable = false;
        PhotonNetwork.NickName = PlayerPrefs.GetString("username");
    }
    public override void OnConnectedToMaster()
    {
        createRoomButton.interactable = true;
        joinRoomButton.interactable = true;
    }
    void SetScreen (GameObject screen)
    {
        //deactivate all screens 
        mainScreen.SetActive(false);
        lobbyScreen.SetActive(false);
        backButton.SetActive(false);
        //enable requested screen
        screen.SetActive(true);
    }
    public void OnCreatedRoomButton (InputField roomNameInput)
    {
        NetworkManager.instance.CreateRoom(roomNameInput.text);
    }
    public void OnJoinRoomButton (InputField roomNameInput)
    {
        NetworkManager.instance.JoinRoom(roomNameInput.text);
    }
    public override void OnJoinedRoom()
    {
        SetScreen(lobbyScreen);
        photonView.RPC("UpdateLobbyUI", RpcTarget.All);
    }
    public override void OnPlayerLeftRoom (Player otherPlayer)
    {
        UpdateLobbyUI();
    }
    [PunRPC]
    public void UpdateLobbyUI()
    {
        playerListText.text = "";
        //display all the players currently in the lobby
        foreach(Player player in PhotonNetwork.PlayerList)
        {
            playerListText.text += player.NickName + "\n";
        }
        // only the host can start the game
        if (PhotonNetwork.IsMasterClient)
            startGameButton.interactable = true;
        else
            startGameButton.interactable = false;
    }
    public void OnLeaveLobbyButton()
    {
        PhotonNetwork.LeaveRoom();
        SetScreen(mainScreen);
    }

    public void OnStartGameButton()
    {
        if (PhotonNetwork.PlayerList.Length > 1)
        {
            PlayerPrefs.SetInt("BattleNumber", 0);
            NetworkManager.instance.photonView.RPC("ChangeScene", RpcTarget.All, "Main ScreenMP");
        }
        else
        {
            //show an error message
        }
    }
}
