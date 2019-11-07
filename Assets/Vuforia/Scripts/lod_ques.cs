using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ques_namespace;
using UnityEngine.SceneManagement;


public class lod_ques : MonoBehaviour
{
    //public Sprite dogImg;
    public GameObject ans1lbl,ans2lbl,ans3lbl,ans1tog,ans2tog,ans3tog,childimg;
    int ques1,ques2,ques3;
    int level;
    int queslevel=1;
    string op1,op2,op3;
    string answer;
    //int penalty=0;
    public GUIStyle style1;
    // Start is called before the first frame update
    Sprite DaSprite;
    
    void Start()
    { 
        Debug.Log("Load question");
        level=gamevar.instance.levelmanager;
        ques1=gamevar.instance.questarry[level*3+0]-1;
        ques2=gamevar.instance.questarry[level*3+1]-1;
        ques3=gamevar.instance.questarry[level*3+2]-1;
        Debug.Log(ques1);
        Debug.Log(ques2);
        Debug.Log(ques3);
    }

    // Update is called once per frame
    void Update()
    {
        if(!gamevar.instance.ardetect.Equals("n")){
            ans1lbl.GetComponent<UnityEngine.UI.Text>().text="Wrong Detection";
            ans2lbl.GetComponent<UnityEngine.UI.Text>().text="Wrong Detection";
            ans3lbl.GetComponent<UnityEngine.UI.Text>().text="Wrong Detection";
            DaSprite = Resources.Load("wrong", typeof(Sprite)) as Sprite;
            childimg.GetComponent<UnityEngine.UI.Image>().sprite=DaSprite;
            return;
        }
        
        if(queslevel==1){
            op1=gamevar.instance.quesobj[ques1].option1;
            op2=gamevar.instance.quesobj[ques1].option2;
            op3=gamevar.instance.quesobj[ques1].option3;  
            
            ans1lbl.GetComponent<UnityEngine.UI.Text>().text=op1;
            ans2lbl.GetComponent<UnityEngine.UI.Text>().text=op2;
            ans3lbl.GetComponent<UnityEngine.UI.Text>().text=op3;
            DaSprite = Resources.Load(gamevar.instance.quesobj[ques1].quest, typeof(Sprite)) as Sprite;
            childimg.GetComponent<UnityEngine.UI.Image>().sprite=DaSprite;
        }
        else if(queslevel==2){
            op1=gamevar.instance.quesobj[ques2].option1;
            op2=gamevar.instance.quesobj[ques2].option2;
            op3=gamevar.instance.quesobj[ques2].option3;
            ans1lbl.GetComponent<UnityEngine.UI.Text>().text=op1;
            ans2lbl.GetComponent<UnityEngine.UI.Text>().text=op2;
            ans3lbl.GetComponent<UnityEngine.UI.Text>().text=op3;
            DaSprite = Resources.Load(gamevar.instance.quesobj[ques2].quest, typeof(Sprite)) as Sprite;
            childimg.GetComponent<UnityEngine.UI.Image>().sprite=DaSprite;
        }else if(queslevel==3){
            
            op1=gamevar.instance.quesobj[ques3].option1;
            op2=gamevar.instance.quesobj[ques3].option2;
            op3=gamevar.instance.quesobj[ques3].option3; 
            ans1lbl.GetComponent<UnityEngine.UI.Text>().text=op1;
            ans2lbl.GetComponent<UnityEngine.UI.Text>().text=op2;
            ans3lbl.GetComponent<UnityEngine.UI.Text>().text=op3;
            DaSprite = Resources.Load(gamevar.instance.quesobj[ques3].quest, typeof(Sprite)) as Sprite;
            childimg.GetComponent<UnityEngine.UI.Image>().sprite=DaSprite;
        }
    }


    //Toggle Fnctions
    public void changestateans1(){
        answer= op1;
    }
    public void changestateans2(){
        answer= op2;
    }
    public void changestateans3(){
        answer= op3;
    }

    //Button Function
    void OnGUI(){
        if(!gamevar.instance.ardetect.Equals("n")){
            return;
        }
        string btname="";

        if(queslevel==1 || queslevel==2){
            btname="Check and next question";
        }else{
            btname="Check and go to next clue";
        }
        if(GUI.Button(new Rect(100,1100,500,100),btname,style1))
        {
            string qans;
            if(queslevel==1){
                qans=gamevar.instance.quesobj[ques1].answer;
                Debug.Log(qans);
                Debug.Log(answer);
                Debug.Log("Level 1");
                Debug.Log(qans==answer);
                if(qans==answer){
                    queslevel++;
                    Debug.Log("Level 1 cleared");
                    ans1tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans2tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans3tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    answer="";
                }else{
                    //gamevar.instance.penalty++;
                     gamevar.instance.penalty++;
                }
            }
            else if(queslevel==2){
                qans=gamevar.instance.quesobj[ques2].answer;
                Debug.Log("Level 2");
                if(qans==answer){
                    queslevel++;
                    Debug.Log("Level 2 cleared");
                    ans1tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans2tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans3tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    answer="";
                }else{
                    //gamevar.instance.penalty++;
                     gamevar.instance.penalty++;
                }
            } 
            else if(queslevel==3){
                qans=gamevar.instance.quesobj[ques3].answer;
                Debug.Log("Level 3");
                if(qans==answer){
                    queslevel++;
                    Debug.Log("Level 3 cleared");
                    ans1tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans2tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    ans3tog.GetComponent<UnityEngine.UI.Toggle>().isOn=false;
                    answer="";
                    //Scene manager over here 
                    gamevar.instance.levelmanager++;
                    if(gamevar.instance.levelmanager==6){
                        SceneManager.LoadScene("arrange");
                    }else{
                        SceneManager.LoadScene("clue");
                    }
                    
                }else{
                    gamevar.instance.penalty++;
                    //penalty++;
                }
            }
        }
    }
}

