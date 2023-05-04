using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLookAt : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        transform.LookAt(Camera.main.transform);

        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward);
    }
}
