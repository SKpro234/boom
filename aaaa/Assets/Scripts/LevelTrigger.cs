using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{

    public LevelLoader LevelScript;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Scene"){
        LevelScript.LoadLevelTwo();
        Debug.Log("trigger");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
