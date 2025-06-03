using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateTargets : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;

    public void DeactivateAll()
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}

