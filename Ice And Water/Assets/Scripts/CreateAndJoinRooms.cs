using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField CreateRoom;
    public InputField JoinRoom;

    public void CreateRooms()
    {
        PhotonNetwork.CreateRoom(CreateRoom.text);
    }
    public void JoinRooms()
    {
        PhotonNetwork.JoinRoom(JoinRoom.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
