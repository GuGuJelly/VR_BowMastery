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

    public void FlyingArrow()
    {

        rigid.AddForce(transform.up*power);

        //Destroy(gameObject, 4f);
    }
}
