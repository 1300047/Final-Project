using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerMove : MonoBehaviour
{
    private float startPosition; 
    private float startAngle;
    private float startTime; 
    public float fightTime;
    public GameObject DefeatBackground;
    public AnimationCurve rotationCurve;
    public AnimationCurve positionCurve;
    

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.y;
        startAngle = transform.eulerAngles.y;
    }

    
    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(transform.position.x, startPosition + positionCurve.Evaluate(Time.time - startTime), transform.position.z);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, startAngle + rotationCurve.Evaluate(Time.time - startTime)*10, transform.eulerAngles.z);
            if(fightTime <= 0.0f){
                DefeatBackground.SetActive(true);
                gameObject.SetActive(false);
            }
            fightTime -= Time.deltaTime;  
    }

    public void SetStart(float time){
        startTime = time;
    }
}
