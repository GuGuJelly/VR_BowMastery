using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ReleaseBow : MonoBehaviour
{
    [SerializeField] XRSocketInteractor socketInter;

    public void ReleaseString()
    {
        if (socketInter != null)
        {
            socketInter.socketActive = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            socketInter.socketActive = true;
        }
    }
}
