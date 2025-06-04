using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsRotate : MonoBehaviour
{

    private float startAngle; 
    public AnimationCurve myCurve;

    // Start is called before the first frame update
    void Start()
    {
        startAngle = transform.eulerAngles.y;
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, startAngle + myCurve.Evaluate(Time.time)*10, transform.eulerAngles.z);
    }
}
