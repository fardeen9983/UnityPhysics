using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering Trigger");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in trigger");
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting Trigger");
        other.gameObject.GetComponent<Renderer>().material.color = Color.clear;
    }


}
