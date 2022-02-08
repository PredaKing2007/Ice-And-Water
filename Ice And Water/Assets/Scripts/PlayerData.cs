using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerData : MonoBehaviour
{
    public bool isIce;
    public bool isFreeze;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = true;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)    
    {
        if (isIce)
        {
            UpdatePlayer(hit.gameObject);
        }
    }
    void UpdatePlayer(GameObject hit)
    {
        PlayerData data = hit.GetComponent<PlayerData>();
        if (data != null)
        {
            data.isFreeze = true;
        }
    }
}
