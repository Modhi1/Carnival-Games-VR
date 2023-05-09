using System.Collections;
using System.Collections.Generic;
using UltimateXR.Animation.Interpolation;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectAnchor : MonoBehaviour
{

    #region Variables
    [SerializeField] private RectTransform _transformObjectToAnchor;

    private float _smoothness = 0.05f;
    private float _offsetX = 3f;
    private Vector3 _sourcePosition;
    private Vector3 _targetPosition;


    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        _sourcePosition = _transformObjectToAnchor.position;
        _targetPosition = transform.position;
        _targetPosition.x += _offsetX;
        // _transformObjectToAnchor.position = transform.position + transform.position * _offsetZ;
      //  _transformObjectToAnchor.position = Vector3.Lerp(_sourcePosition, _targetPosition, Time.time);
       
         _transformObjectToAnchor.position = UxrInterpolator.SmoothDampPosition(_sourcePosition, _targetPosition, _smoothness);
    }
}
