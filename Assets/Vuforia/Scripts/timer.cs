using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timer_text;
    public double startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime=gamevar.instance.startTime;
    }

    // Update is called once per frame
    void Update()
    {
        int t=((int)Time.time - (int)startTime)+gamevar.instance.penalty*30;
        string minutes =((int)t/60).ToString();
        string sec=((int)(t%60)).ToString();
        timer_text.text="Time: "+minutes+":"+sec;
    }
}
