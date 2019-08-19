using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody RigidBody;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(Input.GetAxis("Horizontal") * Speed, 0f, Input.GetAxis("Vertical") * Speed);
        RigidBody.AddForce(force);
    }
}
