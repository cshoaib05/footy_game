using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketBall : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(shoot());
    }

   

    IEnumerator shoot()
    {
        yield return new WaitForSeconds(1f);

        rb.AddForce(transform.forward * 3000);
    }
}
