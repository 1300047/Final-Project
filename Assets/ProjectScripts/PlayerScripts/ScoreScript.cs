using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public int Score;
    public int Shots;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Shots = 0;
    }


    public TMP_Text textmeshPro;
    // Update is called once per frame
    void Update()
    {
        textmeshPro.SetText("You've destroyed {0} targets and taken {1} shots. Would you like to change targets or reset your room to it's default state?", Score, Shots);
    }
}
