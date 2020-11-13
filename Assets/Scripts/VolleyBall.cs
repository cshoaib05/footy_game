using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBall : MonoBehaviour
{
    Rigidbody rb;
    public Animator GoalAnim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * 1000);
        StartCoroutine(shootBall());
    }

    IEnumerator shootBall()
    {
        yield return new WaitForSeconds(1.2f);
        switch (Random.Range(0, 4))
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

        rb.AddForce(transform.forward * 3000f);
    }



}
