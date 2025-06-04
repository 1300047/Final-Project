using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsRotate : MonoBehaviour
{

    private float startPosition; 
    public AnimationCurve myCurve;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.eulerAngles.y;
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, startPosition + myCurve.Evaluate(Time.time)*10, transform.eulerAngles.z);
    }
}
