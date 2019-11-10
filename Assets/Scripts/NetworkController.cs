using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkController : MonoBehaviourPunCallbacks
{

    [SerializeField]
    QuickStartLobbyController quickStartLobby;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log($"Connected to {PhotonNetwork.CloudRegion} server");
        quickStartLobby.QuickStart();
    }
}
