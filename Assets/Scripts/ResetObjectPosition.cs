using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjectPosition : MonoBehaviour
{
    #region Variables 
    private Vector3 startPosition;
    private Vector3 currentPosition;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        if (startPosition != transform.position )
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
