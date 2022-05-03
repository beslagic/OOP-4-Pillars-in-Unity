using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//Derivated Class Cat from Enemy Base Class
public class Cat : Enemy
{
    private void Start()
    {
        poruka = "Cat";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.green;
        RefreshAll();
    }
    
}
