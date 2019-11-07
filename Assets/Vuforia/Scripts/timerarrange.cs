using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerarrange : MonoBehaviour
{
    public Text timer_text;
    public double startTime;
    int check=1;
    // Start is called before the first frame update
    void Start()
    {
        startTime=gamevar.instance.startTime;
    }
void OnGUI(){
        
    }
    // Update is called once per frame
    void Update()
    {
            int t=((int)Time.time - (int)startTime)+gamevar.instance.penalty*30;
            //gamevar.instance.finalTime=t;
            if(gamevar.instance.count==6 && check==1){
                Debug.Log("TIme updated");
                gamevar.instance.finalTime=t;
                check=2;
            }
            
            string minutes =((int)t/60).ToString();
            string sec=((int)(t%60)).ToString();
            timer_text.text="Time: "+minutes+":"+sec;
    }
}