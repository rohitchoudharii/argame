using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_clue : MonoBehaviour
{
    public GameObject cluecont;
    int level,index;
    public GUIStyle style1;
    void Start()
    {
        level=gamevar.instance.levelmanager;
        index=gamevar.instance.cluelevel[level];
        cluecont.GetComponent<UnityEngine.UI.Text>().text=gamevar.instance.clueobj[index];
    }
    void OnGUI(){
        if(GUI.Button(new Rect(600,2100,300,100), "Start The Game",style1)){
            SceneManager.LoadScene("AR");
        }
    }
    
}
