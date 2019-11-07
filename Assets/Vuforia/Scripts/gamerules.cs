using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamerules : MonoBehaviour
{
    public string text="Rules";
    public string rulestext="1.\n2.\n3.\n4.\n5.\n6.\n7.\n8.\n9.\n";
    
    public GUIStyle style1;
    public GUIStyle style2;
    
    public GUIStyle style3;
    //GUI
    void OnGUI()
    {
        GUI.Label(new Rect(600,300,100,40),text,style1);
        GUI.Label(new Rect(100,500,100,40),rulestext,style2);
        if(GUI.Button(new Rect(500,1900,300,100), "Start The Game",style3)){
            //Debug.Log("Button Click");
            gamevar.instance.shuffleClueLevel();
            gamevar.instance.timer_system();
            gamevar.instance.shuffleQuestions();
            SceneManager.LoadScene("clue");
        }
    }
    
}
