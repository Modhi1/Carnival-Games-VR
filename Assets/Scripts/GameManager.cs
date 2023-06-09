using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] GameObject[] cans;
    #endregion
    void Start()
    {
        ResetObjectPosition.canHit += ResetCans;
    }
    void ResetCans()
    {
        StartCoroutine(ResetCansPosition());
    }

    IEnumerator ResetCansPosition()
    {
        yield return new WaitForSeconds(3);

        // loop over cans and reset their position to the default position 
        foreach (GameObject can in cans)
        {
            can.transform.position = can.GetComponent<ResetObjectPosition>().StartPosition;
            can.transform.eulerAngles = can.GetComponent<ResetObjectPosition>().StartRotation;
            can.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

    }


}
