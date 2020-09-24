using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour
{
private PlayerControl thePlayer;
private CameraControl theCamera;
public  bool up;
public  bool down;
public  bool left;
public  bool right;

 //Setting StartDirection.
 //private Vector2 startDirection;
 void Start () 
 {
 

  //Setting Player and Camera Starting Point.
  thePlayer = FindObjectOfType<PlayerControl> ();
  thePlayer.transform.position = transform.position;
  //thePlayer.lastMove = startDirection;
  theCamera = FindObjectOfType<CameraControl> ();
  theCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, theCamera.transform.position.z);

 }
 void Update(){}
}