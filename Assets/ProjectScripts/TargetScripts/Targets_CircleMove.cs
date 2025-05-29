using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets_CircleMove : MonoBehaviour
{
    private float startPositionX;
    //private float startPositionY;
    private float startPositionZ; 
    public AnimationCurve xCurve;
    //public AnimationCurve yCurve;
    public AnimationCurve zCurve;

    // Start is called before the first frame update
    void Start()
    {
        startPositionX = transform.position.x;
        //startPositionY = transform.position.y;
        startPositionZ = transform.position.z;
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(startPositionX + xCurve.Evaluate(Time.time), transform.position.y, startPositionZ + zCurve.Evaluate(Time.time));
    }

}
