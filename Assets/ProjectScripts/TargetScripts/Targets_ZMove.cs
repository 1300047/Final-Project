using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets_ZMove : MonoBehaviour
{

    private float startPosition; 
    public AnimationCurve myCurve;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.z;
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, startPosition + myCurve.Evaluate(Time.time));
    }
}
