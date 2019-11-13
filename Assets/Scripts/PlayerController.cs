using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    new PhotonView photonView;
    [SerializeField]
    GameObject cam;
    void Start() 
    {
        photonView = GetComponent<PhotonView>();
        if(photonView.IsMine)
        {
            cam.SetActive(true);
        }
    }
}
