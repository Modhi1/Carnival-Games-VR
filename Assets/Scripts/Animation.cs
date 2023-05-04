using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private float yPosition;
    private float offset =0.1f;
    void Start()
    {
        yPosition = GetComponent<RectTransform>().position.y;
        LeanTween.moveY(GetComponent<RectTransform>(),yPosition+offset,3f).setLoopPingPong();

       // LeanTween.moveLocalY(gameObject, .5f, 3f).setLoopPingPong();

    }


}