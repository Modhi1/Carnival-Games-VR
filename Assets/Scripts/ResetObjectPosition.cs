using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjectPosition : MonoBehaviour
{
    #region Variables 
    private Vector3 startPosition;
    private Vector3 currentPosition;

    #endregion
    void Start()
    {
        startPosition = transform.position;
    }

   /*
    void Update()
    {
        currentPosition = transform.position;
        if (startPosition != transform.position )
        {
            StartCoroutine(ResetPosition());
        }

    }
*/

    // if the can collides with the ball -> reset its position 

    private void OnCollisionEnter(Collision collision)
    {
        // change this way
        if(collision.collider.name.Equals("Ball"))
        {
            StartCoroutine(ResetPosition());
        }
    }

    IEnumerator ResetPosition()
    {
        yield return new WaitForSeconds(3);

        transform.position = startPosition;
    }

}
