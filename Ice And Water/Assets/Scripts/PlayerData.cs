using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerData : MonoBehaviour
{
    public bool isIce;
    public bool isFreeze;

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Debug.Log("ice");
        }
    }
}
