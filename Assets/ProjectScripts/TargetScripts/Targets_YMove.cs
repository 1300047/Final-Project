using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets_YMove : MonoBehaviour
{

    private float startPosition; 
    public AnimationCurve myCurve;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.y;
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, startPosition + myCurve.Evaluate(Time.time), transform.position.z);
    }
}
