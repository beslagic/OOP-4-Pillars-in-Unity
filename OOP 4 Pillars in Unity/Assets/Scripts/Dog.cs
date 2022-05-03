using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//Derivated Class Cat from Enemy Base Class
public class Dog : Enemy

{
    private void Start()
    {
        poruka = "Dog";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.yellow;
        // Call Enemy.RefreshAll()
        RefreshAll();
    }
   
}
