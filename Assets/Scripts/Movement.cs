using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -0.5f)
        {
            transform.Translate(Vector3.left * 0.5f * Time.deltaTime);
        }

        if (transform.position.x < -0.5f)
        {
            Destroy(gameObject);
        }
    }
}
