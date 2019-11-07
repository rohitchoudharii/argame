using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Homepage_script : MonoBehaviour
{
    public Text p1,p2,p3,phone;
    public void Login(){
        if(phone.text.Length!=10){
            Debug.Log("Wrong number");
            return;
        }
        Debug.Log("Logined");
        hldusername.instance.p1=p1.text;
        hldusername.instance.p2=p2.text;
        hldusername.instance.p3=p3.text;
        hldusername.instance.phone=phone.text;
        SceneManager.LoadScene("rules");
    }

}
