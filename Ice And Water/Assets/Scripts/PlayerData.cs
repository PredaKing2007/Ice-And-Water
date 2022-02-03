using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerData : MonoBehaviour
{
    public bool isIce;
    private ThirdPersonController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ThirdPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isIce)
        {

        }
    }
}
