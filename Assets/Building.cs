using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public bool isBuildable = true;

    private int _collisionHit = 0;

    private void FixedUpdate()
    {
        if (_collisionHit > 0)
        {
            isBuildable = false;
        }
        else
        {
            isBuildable = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Platform") _collisionHit++;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Platform") _collisionHit--;
    }
}