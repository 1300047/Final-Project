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

    private ScoreScript scoreScript;
    public GameObject scoreObject = null;
    private Transform laydown;
    
    void Start() {
        scoreScript = scoreObject.GetComponent<ScoreScript>();
        laydown.rotation.x = startPoint.rotation.x + 90;
        laydown.rotation.y = startPoint.rotation.z + 90;
    }

    public void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, laydown.rotation);

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
