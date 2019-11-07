using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryfile : MonoBehaviour
{
    public int[] arry=new int[6];
    // Start is called before the first frame update
    void Start()
    {
        int i=0;
        arry=gamevar.instance.cluelevel;
        for(i=0;i<arry.Length;i++)
        {
            Debug.Log(arry[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
