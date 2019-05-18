using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entering colison");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Staying colison");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exiting colison");
    }
}
