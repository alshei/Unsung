using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
   [SerializeField] private Transform cameraTransform;
   private Vector3 lastCameraPosition;

   private void Start()
   {
       lastCameraPosition = cameraTransform.position;
   }

   private void LateUpdate()
   {
       Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
       transform.position += deltaMovement;
       lastCameraPosition = cameraTransform.position;
   }

}
