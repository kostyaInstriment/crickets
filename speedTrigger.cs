using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    
    void OnTriggerEnter(Collider other)
    {
        //увелечение скорости бега
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //понижениу скорости бега
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
