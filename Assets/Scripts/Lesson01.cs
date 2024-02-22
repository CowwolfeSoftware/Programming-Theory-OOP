using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson01 : MonoBehaviour
{
    // Start is called once before any Update methods are called
    void Start()
    {
        
    }

    // Awake called when script instance is laoted
    void Awake() { }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
    }

    // Updated once every fixed framerate
    void FixedUpdate()
    {
    }

    // for rendering and handling GUI events; might be called several times per frame.
    //void OnGUI() {}

    // Trigger events will be sent to disabled MonoBehaviours, 
    // to allow enabling Behaviours in response to collisions.
    // called when collider encounts the trigger
    // methods are only called if the Collider that was hit has IsTrigger = True.
    //void OnTriggerEnter(Collider other) {}
    //void OnTriggerStay(Collider other) {}
    //void OnTriggerExit(Collider other) {}

    // Collision events will be sent to disabled MonoBehaviours,
    // to allow enabling Behaviours in response to collisions
    // called when this collider/rigidbody encounters another rigidbody/collider
    // methods are only called if the Collider that was hit has IsTrigger = False.
    //void OnCollisionEnter(Collision other) {}
    //void OnCollisionStay(Collision other) {}
    //void OnCollisionExit(Collision other) {}
}
