using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjectPosition : MonoBehaviour
{
    #region Variables 

    public static Action canHit;
    private Vector3 startPosition;
    public Vector3 StartPosition { get => startPosition; }


    #endregion
    void Start()
    {
        startPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // change this way
        if(collision.collider.name.Equals("Ball"))
        {
            canHit?.Invoke();
        }
    }


}
