using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanDestroy : MonoBehaviour
{
    public ScoreScript scoreScript;
    public SummonDestroyer destroyer;
    //public GameObject scoreObject = null;
    
    void Start() {
        //scoreScript = scoreObject.GetComponent<ScoreScript>();
    }

    public void IsHit(){
        if(scoreScript != null){
            scoreScript.Score += 1;
            destroyer.minions -= 1;
            gameObject.SetActive(false);
        }
    }
}
