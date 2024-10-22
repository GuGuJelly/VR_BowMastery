using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowRotation : MonoBehaviour
{
    [SerializeField] Transform controller_Dir;

    public void BowDirection()
    {
        transform.rotation = Quaternion.LookRotation(controller_Dir.forward);
    }
}
