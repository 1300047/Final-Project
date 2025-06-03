using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using System;

public class DestroyProjectile : MonoBehaviour
{

    [Serializable] public class CollisionEvent : UnityEvent<Collision> { }

    private int collisions = 0;

    private void OnCollisionExit(Collision collision)
    {
        collisions += 1;
        if(collisions >= 2){
            Destroy(gameObject);
        }
    }
}
