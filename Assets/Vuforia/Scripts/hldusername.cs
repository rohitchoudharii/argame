using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using scoresclass;

public class hldusername : MonoBehaviour
{
    public static hldusername instance{get; private set;}
    public string p1,p2,p3,phone;
    public score data;
    public string BASE_URL="PUT FIREBASE URL";
    private DatabaseReference databaseReference;
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
    public void uploadscore(int t){
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(BASE_URL);
        databaseReference=FirebaseDatabase.DefaultInstance.RootReference;
        Debug.Log("Load Data");
        Debug.Log(t);
        data = new score(p1,p2,p3,t,phone);
        string jsonData=JsonUtility.ToJson(data);
        databaseReference.Child(phone).SetRawJsonValueAsync(jsonData);
    }
}
