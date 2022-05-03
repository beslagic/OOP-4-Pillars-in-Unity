using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//Derivated Class Cat from Enemy Base Class
public class Dog : Enemy

{    private void Start()
    {
        //ABSTRACTION
        SetVariable();
    }

    private void SetVariable()
    {
        poruka = "Dog";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.yellow;
        jumpForce = 100f;
    }
    //POLYMORHISM - change ForceMode for Dog
    protected override void Jump()
    {   if (jumpForce < 200)
        {
            Rigidbody rgObject = gameObject.GetComponent<Rigidbody>();
            rgObject.AddForce(Vector3.up * jumpForce, ForceMode.Force);
        } else
        {
            Rigidbody rgObject = gameObject.GetComponent<Rigidbody>();
            rgObject.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

}
