using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerData : MonoBehaviour
{
    public bool isIce;
    private CharacterController controller;
    private ThirdPersonController personController;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        personController = GetComponent<ThirdPersonController>();
        controller.detectCollisions = true;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)    
    {
        if (isIce)
        {
            ThirdPersonController personController = hit.gameObject.GetComponent<ThirdPersonController>();
            if (personController != null)
            {
                personController.isFreeze = true;
            }
        }
    }
}
