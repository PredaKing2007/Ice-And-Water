using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class PlayerData : MonoBehaviour
{
    public bool isIce;
    public bool isFreeze;
    public float Range;
    public string playerTag = "Player";
    List<GameObject> target = new List<GameObject>();
    void Awake()
    {
        target.Clear();
        InvokeRepeating("CheckForPlayers", 0f, 1f);
    }
    void CheckForPlayers()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag(playerTag);
        if (players.Length > 1)
        {
            float shortestDis = Mathf.Infinity;
            List<GameObject> nearestPlayer = new List<GameObject>();
            foreach (GameObject enemy in players)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);
                Debug.Log(distance);
                if (distance < shortestDis)
                {
                    Debug.Log("Found");
                    //shortestDis = distance;
                    //nearestPlayer.Add(enemy);
                }
            }
            if (nearestPlayer.Count > 1 && shortestDis <= Range)
            {
                target = nearestPlayer;
                //Debug.Log(target.Count);
            }
            else
                target = null;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Range);
    }
}
