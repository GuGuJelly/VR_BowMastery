using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ArrowCollider : MonoBehaviour
{
    [SerializeField] GameObject arrowDistance;
    [SerializeField] Transform arrowAttachPoint;

    private float difDistance;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            difDistance = arrowDistance.transform.position.x - arrowAttachPoint.position.x;
            if (Input.anyKey)
            {
                transform.Translate(Vector3.forward*difDistance*Time.deltaTime,Space.Self);
            }

        }
    }
}
