using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mainbehav : MonoBehaviour
{
    public GameObject mind,power,time,soul,space,reality,mindplace,powerplace,timeplace,soulplace,spaceplace,realityplace;
    Vector2 mindint,powerint,timeint,soulint,spaceint,realityint;
    int count=0;
    //public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
        mindint = mind.transform.position;
        powerint = power.transform.position;
        timeint = time.transform.position;
        soulint = soul.transform.position;
        spaceint = space.transform.position;
        realityint = reality.transform.position;
       // Debug.Log(mindint);
        //Debug.Log(powerint);
        //Debug.Log(timeint);
       // Debug.Log(soulint);
       //Debug.Log(spaceint);
       // Debug.Log(realityint);
    }

    public void Dragmind(){
        mind.transform.position=Input.mousePosition;

    }
    public void Dragpower(){
        power.transform.position=Input.mousePosition;
        
    }
    public void Dragtime(){
        time.transform.position=Input.mousePosition;
        
    }
    public void Dragsoul(){
        soul.transform.position=Input.mousePosition;
        
    }
    public void Dragspace(){
        space.transform.position=Input.mousePosition;
        
    }
    public void Dragreality(){
        reality.transform.position=Input.mousePosition;
        //Debug.Log(Input.mousePosition);
    }
    public void Dropmind(){
        float Distance= Vector3.Distance(mind.transform.position,mindplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            mind.transform.position=mindplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            mind.transform.position=mindint;
            //gamevar.instance.penalty++;
        }
       

    }
    
    public void Droppower(){
        float Distance=Vector3.Distance(power.transform.position,powerplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            power.transform.position=powerplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            power.transform.position=powerint;
            //gamevar.instance.penalty++;
        }
        

    }
    public void Droptime(){
        float Distance=Vector3.Distance(time.transform.position,timeplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            time.transform.position=timeplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            time.transform.position=timeint;
            //gamevar.instance.penalty++;
        }
        

    }
    public void Dropsoul(){
        float Distance=Vector3.Distance(soul.transform.position,soulplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            soul.transform.position=soulplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            soul.transform.position=soulint;
            //gamevar.instance.penalty++;
        }
       

    }
    public void Dropspace() {
        float Distance=Vector3.Distance(space.transform.position,spaceplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            space.transform.position=spaceplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            space.transform.position=spaceint;
            //gamevar.instance.penalty++;
        }
        

    }
    public void Dropreality()
    {
        float Distance=Vector3.Distance(reality.transform.position,realityplace.transform.position);
        Debug.Log(Distance);
        if(Distance<35)
        {
            reality.transform.position=realityplace.transform.position;
            //gamevar.instance.count++;
        }
        else
        {
            reality.transform.position=realityint;
            //gamevar.instance.penalty++;
        }
        


    }

    void OnGUI(){
        //if(gamevar.instance.count==6){
            if(GUI.Button(new Rect(300,900,300,100), "Start The Game")){
                //hldusername.instance.uploadscore(gamevar.instance.finalTime);
            }
        //}
    }
    
}
