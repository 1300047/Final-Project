using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonDestroyer : MonoBehaviour
{
    public int minions;
    public int hp;
    public ScoreScript scoreScript;
    public GameObject SummonBackground;
    public GameObject VictoryBackground;
    private DestroyerMove move;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        minions = 5;
        hp = 30;
        move = GetComponent<DestroyerMove>();
        startTime = 0.0f;
    }


    public void Summon(){
        startTime = Time.time;
        move.enabled = !move.enabled;
        move.SetStart(startTime);
    }

    public void IsHit(){
        if(scoreScript != null){
            scoreScript.Score += 1;
        }
        hp -= 1;
        if(hp <= 0){
             gameObject.SetActive(false);
             VictoryBackground.SetActive(true);
        }
    }


     // Update is called once per frame
    void Update()
    {
        if(minions == 0){
            SummonBackground.SetActive(true);
            minions = -1;
        }
    }

}
