using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueScript : MonoBehaviour
{
    public int speed;
    Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        speed = 50;
    }
    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(-transform.up * speed * Input.GetAxis("Horizontal") * Time.deltaTime);
        rigidbody.AddTorque(transform.right * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        
    }
}
