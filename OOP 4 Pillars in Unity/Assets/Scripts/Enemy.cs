using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base Class Enemy
public class Enemy : MonoBehaviour
{
    protected string poruka;
    protected GameObject childObject;
    protected Color color;

    // Start is called before the first frame update
    private void Start()
    {
        poruka = "Enemy";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.blue;
        //ABSTRACTION
        RefreshAll();
    }

    // Update is called once per frame
   public void Update()
    { 
        if (Input.GetMouseButtonDown(0)) {  }
    }


    protected virtual void Move()
    {

    }
    //ABSTRACTION
    protected void RefreshAll() 
    {
        childObject.transform.root.GetComponentInParent<Renderer>().material.color = color;
        childObject.GetComponent<TextMesh>().text = poruka;
    }
    
}
