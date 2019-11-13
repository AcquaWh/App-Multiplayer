using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float rotSpeed;
    [SerializeField]
    GameObject cam;
    void Start() 
    {
        if(photonView.IsMine)
        {
            cam.SetActive(true);
        }
    }

    void Update()
    {
        if(!photonView.IsMine) return;
        transform.Translate(Vector3.forward * axis.z * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * axis.x * rotSpeed * Time.deltaTime);
    }

    Vector3 axis{get => new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); }
}
