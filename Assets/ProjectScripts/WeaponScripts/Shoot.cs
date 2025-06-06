using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   [Tooltip("The projectile that's created")]
    public GameObject projectilePrefab = null;

    [Tooltip("The point that the projectile is created")]
    public Transform startPoint = null;

    [Tooltip("The speed at which the projectile is launched")]
    public float launchSpeed = 1.0f;

    public ScoreScript scoreScript = null;
    public Transform projectileRotation = null;
    
    void Start() {
        //scoreScript = scoreObject.GetComponent<ScoreScript>();
        
    }

    public void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, projectileRotation.rotation);

        if (newObject.TryGetComponent(out Rigidbody rigidBody))
            ApplyForce(rigidBody);

        scoreScript.Shots += 1;
    }

    private void ApplyForce(Rigidbody rigidBody)
    {
        Vector3 force = startPoint.forward * launchSpeed;
        rigidBody.AddForce(force);
    }
}
