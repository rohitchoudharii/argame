using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ques_namespace;
using System.IO;
using System.Text;

public class gamevar : MonoBehaviour
{
    public static gamevar instance{get; private set;}
    public int levelmanager=0;
    public double startTime;
    public int finalTime;
    public int penalty=0;
    public int count=0;
    public string ardetect="n";
    
    //shuffle the cluelevel
    System.Random rnd=new System.Random();
    public int[] cluelevel=new int[6];
    public int[] questarry=new int[18];
    public question[] quesobj=new question[32];
    public string[] clueobj=new string[6];
    // Start is called before the first frame update
    void Awake()
    {
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(gameObject);
        }   
        else{
            Destroy(this);
        }
    }
    void Start(){
        // clueobj
        clueobj[0]="Find your daily grub here, or simply spend your time with friends.";
        clueobj[1]="You have to input your PID before you can go in.";
        clueobj[2]="The person who does not let you in without an ID card.";
        clueobj[3]="historic cache of goods or information, usually intended as a deliberate method of communication with future people, and to help future archaeologists, anthropologists, or historians.";
        clueobj[4]="Helps you get a placement.";
        clueobj[5]="Park here. Park there. Park anywhere. Park in a queue.";


        //Load Question
        quesobj[0]=new question("Q1","Avengers","Iron Man 3","Iron Man","Iron Man 3");
        quesobj[1]=new question("Q2","Ant-Man","Thor ","Guardians of The Galaxy Vol 2","Guardians of The Galaxy Vol 2");
        quesobj[2]=new question("Q3","Doctor Strange","Captain America The Winter Soldier","Avengers Age of Ultron","Captain America The Winter Soldier");
        quesobj[3]=new question("Q4","Captain America The Civil War","Captain America The Winter Soldier","Avengers Infinity War","Captain America The Civil War");
        quesobj[4]=new question("Q5","Iron Man 3","Iron Man 2","Iron Man 1","Iron Man 2");
        quesobj[5]=new question("Q6","Avengers ","Captain America","Guardians of Galaxy Vol 1","Captain America");
        quesobj[6]=new question("Q7","Avengers","Thor","Avengers Age of Ultron","Avengers");
        quesobj[7]=new question("Q8","Thor Ragnarok","Avengers Age of Ultron","Thor","Avengers Age of Ultron");
        quesobj[8]=new question("Q9","Incredible Hulk","Iron Man 1","Captain America The Civil War","Iron Man 1");
        quesobj[9]=new question("Q10","Avengers Age of Ultron","Spiderman Homecoming","Avengers","Spiderman Homecoming");
        quesobj[10]=new question("Q11","Thor","Iron Man 2","Incredible Hulk","Thor");
        quesobj[11]=new question("Q12","Guardians of the Galaxy Vol2","Thor","Doctor Strange","Doctor Strange");
        quesobj[12]=new question("Q13","Spiderman Homecoming","Guardians of The Galaxy","Avengers Age of Ultron","Guardians of The Galaxy");
        quesobj[13]=new question("Q14","Iron Man 2","Hulk","Avengers Infinity War","Hulk");
        quesobj[14]=new question("Q15","Iron Man 2","Ant-Man","Avengers","Ant-Man");
        quesobj[15]=new question("Q16","Captain America The Civil War","Guardians of The Galaxy","Avengers","Guardians of The Galaxy");
        quesobj[16]=new question("Q17","Captain America The Winter Soldier","Captain Marvel","Hulk","Captain Marvel");
        quesobj[17]=new question("Q18","Doctor Strange","Avengers","Thor Ragnarok","Doctor Strange");
        quesobj[18]=new question("Q19","Yale","Brown","Harvard","Brown");
        quesobj[19]=new question("Q20","Hulk","Iron Man 3","Avengers Infinity War","Iron Man 3");
        quesobj[20]=new question("Q21","Rhodey","Bruce Banner","Nick Fury","Nick Fury");
        quesobj[21]=new question("Q22","He utilised >Omni Thermal Technique> to keep the suit from icing.","He used a gold-titanium alloy from a satellite design that wasn>t prone to freezing.","He implemented a solar matrix system to monitor proper heating levels.","He used a gold-titanium alloy from a satellite design that wasn>t prone to freezing.");
        quesobj[22]=new question("Q23","Clark Gregg","Don Cheadle","Terrence Howard","Terrence Howard");
        quesobj[23]=new question("Q24","Ivan Vanko","Ho Yinsen","Abu Bakaar","Ho Yinsen");
        quesobj[24]=new question("Q25","Black Panther","Spider-Man: Far From Home","Avengers:Infinity War","Spider-Man: Far From Home");
        quesobj[25]=new question("Q26","Mark III","Mark II","Mark IV","Mark II");
        quesobj[26]=new question("Q27","The Narco Missile","The Arc Missile","The Jericho Missile","The Jericho Missile");
        quesobj[27]=new question("Q28","Venom","SpiderMan Homecoming","Avengers","Avengers");
        quesobj[28]=new question("Q29","Dark Phoenix","Thor Ragnarok","Spider-Man:Far From Home","Thor Ragnarok");
        quesobj[29]=new question("Q30","Ant-Man and the Wasp","Doctor Strange","Captain America The Winter Soldier","Ant-Man and the Wasp");
        quesobj[30]=new question("Q31","Deadpool","Iron Man 2","Avengers:Age of Ultron","Deadpool");
        quesobj[31]=new question("Q32","Kabul","Kandahar","Gulmira","Gulmira");
    }
    public void shuffleQuestions()
    {
        shuffleques(questarry);
        //Debug.Log("shuffleClueLevel");
    }
    //Public Function;
    public void timer_system(){
        startTime=Time.time;
    }
    public void shuffleClueLevel()
    {
        cluelevel= new int[6]{0,1,2,3,4,5};
        shuffleArray(cluelevel);
        //Debug.Log("shuffleClueLevel");
    }
    // private funtions;
    private void shuffleArray(int[] arr){
        int n=arr.Length;
        //Debug.Log("shuffleArray");
        for (int i = 0; i < n; i++)
            swap(arr,i,rnd.Next(n-i));
    }
    
    private void swap(int[] arr,int a,int b){
        int temp=arr[a];
        arr[a]=arr[b];
        arr[b]=temp;
        //Debug.Log("Swap");
    }
    private void shuffleques(int[] arr){
        int i=0;
        while(i<18){
            int inp=rnd.Next(33);
           // Debug.Log(inp);
            int f=System.Array.IndexOf(arr,inp);
            if(f==-1){
            arr[i]=inp;
            i++;
            }
        }
    }

}