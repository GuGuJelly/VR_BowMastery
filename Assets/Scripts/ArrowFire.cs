using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFire : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;

    [SerializeField] float power;

    //private void Start()
    //{
    //    ArrowisFlying = StartCoroutine(arrowFlying());
    //}

    private void Start()
    {
        rigid.MoveRotation(Quaternion.LookRotation(rigid.velocity, transform.up));
    }

    public void FlyingArrow()
    {
        rigid.AddForce(transform.up*power);

        //Destroy(gameObject, 4f);
    }
}
