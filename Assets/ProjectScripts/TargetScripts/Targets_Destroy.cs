using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Targets_Destroy : MonoBehaviour
{
    private ScoreScript scoreScript;
    public GameObject scoreObject = null;
    
    void Start() {
        scoreScript = scoreObject.GetComponent<ScoreScript>();
    }

    public void IsHit(){
        if(scoreScript != null){
            scoreScript.Score += 1;
            Destroy(gameObject);
        }
    }
}
