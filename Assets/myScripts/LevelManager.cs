using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{   
    public static LevelManager instance;

    public GameObject respawnPoint;
    public GameObject playerPrefab;
    public CinemachineVirtualCameraBase cam;
    private void Awake()
    {
            instance = this;
    }
    public void Respawn()
    {
        GameObject player = Instantiate(playerPrefab,respawnPoint.transform.position,Quaternion.identity);
        cam.Follow = player.transform;
    }
}
