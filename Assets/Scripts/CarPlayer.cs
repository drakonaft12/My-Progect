using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CarPlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private bool Work = false;

    private void OnCollisionStay(Collision collision)
    {
        Work = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Work = false;
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0f && Work)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 2000 * Input.GetAxis("Vertical"));
            GetComponent<Rigidbody>().AddForce(transform.up * 200 * Input.GetAxis("Vertical"));
        }
        if (Input.GetAxis("Horizontal") != 0f && Work)
        {
            Quaternion quaternion = Quaternion.Euler(new Vector3(0,1,0) * Input.GetAxis("Horizontal"));
            GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * quaternion);
        }
    }
}
