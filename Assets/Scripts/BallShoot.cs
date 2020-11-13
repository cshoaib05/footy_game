using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    Rigidbody rb;
    public Animator GoalAnim;
    public Animator Meter;
    bool rotate;
    public float angleshoot;
    void Start()
    {
        rotate = true;
        rb = GetComponent<Rigidbody>();
        StartCoroutine(shoot());
        StartCoroutine(Rotate());
    }

    void FixedUpdate()
    {   
        if(rotate)
        {
            transform.Rotate(transform.up, angleshoot);
        }

        if(Input.GetMouseButtonDown(0))
        {
            rotate = false;
            Meter.gameObject.GetComponent<Animator>().enabled = false;

        }
        
    }

    IEnumerator shoot()
    {
        yield return new WaitForSeconds(3.9f);

        switch(Random.Range(0,4))
        {
            case 0:
                GoalAnim.SetTrigger("goalright");
                break;
            case 1:
                GoalAnim.SetTrigger("goalleft");
                break;
            case 2:
                GoalAnim.SetTrigger("BodyLeft");
                break;
            case 3:
                GoalAnim.SetTrigger("BodyRight");
                break;
        }

        
        rb.AddForce(transform.forward * 3000);
        print(transform.forward);
    }

    IEnumerator Rotate()
    {
        yield return new WaitForSeconds(1.5f);
        rotate = false;
    }
}
