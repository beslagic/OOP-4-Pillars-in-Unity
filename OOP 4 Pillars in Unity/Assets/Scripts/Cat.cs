using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//Derivated Class Cat from Enemy Base Class
public class Cat : Enemy
{
    private void Start()
    {
        //ABSTRACTION
        SetVariable();    
    }
    
    //ABSTRACTION
    private void SetVariable()
    {
        poruka = "Cat";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.green;
        jumpForce = 5f;
    }

}
