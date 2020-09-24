using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogueholder : MonoBehaviour
{

    private Dialogue dLog;
    public string[] sentences;
    private bool click;
    private bool playerInRange;

    void Start()
    {
     dLog=FindObjectOfType<Dialogue>();
     Debug.Log("is this working");
     click = false;
    }

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.X) && playerInRange){

            click=true;
             dLog.ShowBox(sentences);


    }
    }


    void OnTriggerEnter2D(Collider2D other){

        if(other.name=="Icarus"){
                Debug.Log("Player in range");
                playerInRange=true;
        }

    }

    void OnTriggerExit2D(Collider2D other){
        if(other.name=="Icarus"){
            Debug.Log("Player out of range");
            playerInRange=false;
        }
    }
}
