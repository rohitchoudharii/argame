using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ques_namespace
{
    public class question 
    {
        public string quest;
        public string option1,option2,option3;
        public string answer;
        public question(string ques,string op1,string op2,string op3,string ans){
            quest=ques;
            option1=op1;
            option2=op2;
            option3=op3;
            answer=ans;
        }
    }
}

