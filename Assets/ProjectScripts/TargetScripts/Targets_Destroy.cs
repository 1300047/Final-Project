using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets_Destroy : MonoBehaviour
{
    public void IsHit(){
        Destroy(gameObject);
    }
}
