using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{

    public PlayerControl player;
    private CinemachineVirtualCamera vcam;

    void Start()
    {
    //var virtualCamera = GameObject.FindGameObjectWithTag("VirtualCamera");
    //var confiner = virtualCamera.GetComponent<CinemachineConfiner>();
    player=FindObjectOfType<PlayerControl>();
    var vcam = GetComponent<CinemachineVirtualCamera>();
    vcam.Follow  = player.transform;

    //confiner.InvalidatePathCache();
    //confiner.m_BoundingShape2D = GameObject.FindGameObjectWithTag("Boundary").GetComponent<PolygonCollider2D>();



    }
    void Update()
    {
     
    }

}
