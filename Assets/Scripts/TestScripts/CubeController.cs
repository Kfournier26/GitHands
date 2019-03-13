using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        Vector3 v = Vector3.zero;


        if (GenericHandInputManager.Instance.RightHand.point > 0)
        {
            Debug.Log("Adding force");

            v += Vector3.up * 5 * GenericHandInputManager.Instance.RightHand.point;
        }

        if (GenericHandInputManager.Instance.LeftHand.point > 0)
        { 

        // Debug.Log("Left Hand: " + GenericHandInputManager.Instance.LeftHand.point);
        v += (Vector3.back * 5 * GenericHandInputManager.Instance.LeftHand.point);
        }
        rb.velocity = v;
    }
}
