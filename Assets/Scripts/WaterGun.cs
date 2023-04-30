using System.Collections;
using System.Collections.Generic;
using UltimateXR.Core.Components.Composite;
using UltimateXR.Manipulation;
using UnityEngine;

public class WaterGun : UxrGrabbableObjectComponent<WaterGun>
{
    #region Variables
    [SerializeField] ParticleSystem part;
    #endregion

 

    // Update is called once per frame
    void Update()
    {
        // play particle system when the gun is grabbed (first check if the ParticleSystem is not on play)
        
        if (UxrGrabManager.Instance.IsBeingGrabbed(GrabbableObject))
        {
            if(!part.isPlaying)
            {
                part.Play();
            }
            
        }
        else
        {
            part.Stop();
        }
    }
}
