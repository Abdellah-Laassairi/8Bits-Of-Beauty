using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//I have no idea what half of this actually does
//Make the audio synchronized to the writing
public class Dialogue : MonoBehaviour
{
    public GameObject dBox;
    public AudioSource sans;
    public TextMeshProUGUI textDisplay;
    private int index;
    public float TypingSpeed;   
    public bool dialogActive;
    public bool skip;
    void start(){
         dBox.SetActive(false);
         //StartCoroutine(Type());
    }
    //Press Space to skip the dialogue dumbass
    //Press P to start the dialogue *cough* add it later
    void Update(){

        if(dialogActive && Input.GetKeyDown(KeyCode.Space)){
            dBox.SetActive(false);
            dialogActive=false;
            sans.Stop();
        }
        if(!dialogActive){
            dBox.SetActive(false);
            sans.Stop();
        }
        skip=Input.GetKeyDown(KeyCode.P);

    }
    public void ShowBox(string[] sentences){
        dBox.SetActive(true);
        dialogActive=true;
        StartCoroutine(Type(sentences));
        Type(sentences);
        textDisplay.text="";
        
    }
    IEnumerator Type(string[] sentences){
        int lenght =sentences.Length;
        sans.Play();
        foreach (char letter in sentences[0].ToCharArray())
        {
            
            textDisplay.text+=letter;
            yield return new WaitForSeconds(TypingSpeed);
        }
        sans.Stop();
        int i=1;        
        while(i<lenght && skip){
            textDisplay.text="";
            foreach (char letter in sentences[i].ToCharArray())
        {
            textDisplay.text+=letter;
            yield return new WaitForSeconds(TypingSpeed);
        };
        i++;
        }
    }
}
