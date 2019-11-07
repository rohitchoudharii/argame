using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class penal : MonoBehaviour
{
    public Text pen;
    void Update(){
        pen.text=gamevar.instance.penalty.ToString();
    }
}
