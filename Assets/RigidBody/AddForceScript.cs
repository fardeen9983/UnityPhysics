﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500,ForceMode.Acceleration);
    }
}
