using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjectPosition : MonoBehaviour
{
    #region Variables 

    public static Action canHit;
    private Vector3 startPosition;
    private Vector3 startRotation;
    public Vector3 StartPosition { get => startPosition; }
    public Vector3 StartRotation { get => startRotation; }

    #endregion
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.eulerAngles;
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
