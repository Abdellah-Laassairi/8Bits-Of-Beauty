using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is basically steve's controls 
public class CharachterControl : MonoBehaviour
{
    private Animator anim; 
    public float moveSpeed;
    private bool PlayerMoving;
    private Vector2 lastmove;
    private Rigidbody2D myRigidBody;
    private static bool playerExists;
    //private AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        myRigidBody=GetComponent<Rigidbody2D>();
        //audioSrc= gameObject.GetComponent<AudioSource>();

        if(!playerExists){

        playerExists=true;
        DontDestroyOnLoad(transform.gameObject);
        
        }else{
            Destroy(gameObject);
        }

    }
    // I don't like the idea that there are higher beings playing us right now
    // LOWER THE DAMN DIFFICULTY IDIOTS
    // Update is called once per frame
    void Update()
    {
        PlayerMoving=false;
        if (Input.GetAxisRaw("SecondHorizontal") > 0.5f || Input.GetAxisRaw("SecondHorizontal") < -0.5f )
        {
            myRigidBody.velocity=new Vector2(Input.GetAxisRaw("SecondHorizontal")*moveSpeed, myRigidBody.velocity.y);
            PlayerMoving=true;
            lastmove= new Vector2(Input.GetAxisRaw("SecondHorizontal"), 0f);
        }
        if (Input.GetAxisRaw("SecondVertical") > 0.5f || Input.GetAxisRaw("SecondVertical") < -0.5f)
        {
            myRigidBody.velocity=new Vector2(myRigidBody.velocity.x, Input.GetAxisRaw("SecondVertical")*moveSpeed);
            PlayerMoving=true;
            lastmove= new Vector2(0f, Input.GetAxisRaw("SecondVertical"));
        }
        if(Input.GetAxisRaw("SecondHorizontal")<0.5f && Input.GetAxisRaw("SecondHorizontal")>-0.5f){
            myRigidBody.velocity= new Vector2(0f,myRigidBody.velocity.y );

        }
        if(Input.GetAxisRaw("SecondVertical")<0.5f && Input.GetAxisRaw("SecondVertical")>-0.5f){
            myRigidBody.velocity= new Vector2(myRigidBody.velocity.x, 0f);
        }
        anim.SetFloat("LastMoveX",Input.GetAxisRaw("SecondHorizontal"));
        anim.SetFloat("LastMoveY",Input.GetAxisRaw("SecondVertical"));
        anim.SetBool("PlayerMoving",PlayerMoving);
        anim.SetFloat("LastMoveX",lastmove.x);
        anim.SetFloat("LastMoveY",lastmove.y);

        if(PlayerMoving){
            //audioSrc.Play();
        }else{
            //audioSrc.Stop();
        }

    }
}
