using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTargets : MonoBehaviour
{
    public GameObject[] objectsToActivate;

    public void ActivateAll()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
}
