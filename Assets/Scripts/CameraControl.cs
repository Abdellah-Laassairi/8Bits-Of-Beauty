using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private static bool cameraExists;
    public Transform player;
    
    void Start()
    {
    //var virtualCamera = GameObject.FindGameObjectWithTag("VirtualCamera");
    //var confiner = virtualCamera.GetComponent<CinemachineConfiner>();
    //confiner.InvalidatePathCache();
    //confiner.m_BoundingShape2D = GameObject.FindGameObjectWithTag("Boundary").GetComponent<PolygonCollider2D>();


    //This block instructs unity to not destroy the camera between scene transitions
    if(!cameraExists){
    cameraExists=true;
    DontDestroyOnLoad(transform.gameObject);

    } else {
    Destroy(gameObject);
    }

    }
    void Update()
    {
         //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

}
