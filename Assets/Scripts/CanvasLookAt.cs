using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CanvasLookAt : MonoBehaviour
{
    #region Variables
    private RectTransform _objectTransform;
    private Vector3 _rotation;
    #endregion

    private void Start()
    {
        _objectTransform = gameObject.GetComponent<RectTransform>();

        _rotation = _objectTransform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer() 
    {

        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, 0);
        //  _objectTransform.LookAt(Camera.main.transform);

        //  _objectTransform.LookAt(_objectTransform.position + Camera.main.transform.rotation * Vector3.back, Camera.main.transform.rotation * Vector3.up);

        //   _objectTransform.LookAt(_objectTransform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);

       // _objectTransform.LookAt(Camera.main.transform, _objectTransform.position + Camera.main.transform.rotation * Vector3.forward);
    }
}

