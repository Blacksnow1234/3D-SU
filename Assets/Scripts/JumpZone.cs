using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    public float jumpForce = 170f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if(rb != null )
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
