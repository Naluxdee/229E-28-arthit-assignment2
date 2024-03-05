using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    void FixedUpdate()
    {
        if (Input.GetKey( KeyCode.Space ))
        {
            //Add Thrust
            rb.AddForce( transform.forward * enginePowerThrust );
        }

        //Lift
        Vector3 lift = Vector3.Project( rb.velocity, transform.forward );
        rb.AddForce( transform.up * lift.magnitude * liftBooster );

        //Drag
        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        //Control left-right
        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);

        //Up-Down
        rb.AddTorque( Input.GetAxis("Vertical") * transform.right );

    }
}
