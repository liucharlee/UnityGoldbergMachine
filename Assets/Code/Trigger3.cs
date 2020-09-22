using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public Transform cameraTransform; // "public" = it will be exposed in the Unity editor inspector
     //public Transform cameraTransform; // "public" = it will be exposed in the Unity editor inspector
    //Transform cameraFollowTarget; // no public = private, it will NOT be exposed to the Unity editor inspector

    // see https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html
    // automatically happen when something with a Rigidbody2D enters this trigger
    void OnTriggerEnter2D(Collider2D activator) {
        cameraTransform.position = new Vector3( 75f, -20f, -10f );
    }
}
