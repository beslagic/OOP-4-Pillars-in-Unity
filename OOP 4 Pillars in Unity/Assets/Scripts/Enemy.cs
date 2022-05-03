using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//Base Class Enemy
public class Enemy : MonoBehaviour
{
    private string m_poruka;
    [SerializeField] protected string poruka;
    [SerializeField] protected GameObject childObject;
    [SerializeField] protected Color color;
    [SerializeField] protected float jumpForce;
    [SerializeField] protected float speed;

    // Start is called before the first frame update
    private void Start()
    {
        poruka = "Enemy";
        childObject = gameObject.transform.GetChild(0).gameObject;
        color = Color.blue;
        //ABSTRACTION
        Refresh();
    }

    //ENCAPSULATION
    public string Poruka
    {
        get { return m_poruka; }
        set {
            //If valuse is more then 20 characters 
            if (value.Length > 20)
            {
                Debug.LogError("You cannot set a value longer than 20 characters.");
            }
            else
            {
                m_poruka = value;
            }
        }
    }
    //POLYMORHISM - IN DOG CLASS
    protected virtual void Jump()
    {
        Rigidbody rgObject = gameObject.GetComponent<Rigidbody>();
        rgObject.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
    }

    public void Update()
    {
        //ABSTRATION
        MouseClick();
    }

    //ABSTRATION - Implementation
    protected virtual void MouseClick()
    {
        // Press left mouse button for action
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.collider.name);
            // If collider name is same as Object name then action
            if(hit.collider.name == this.name) Refresh();
        }
        // Press right mouse button for action
        if (Input.GetMouseButtonDown(1)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.collider.name);
            // If collider name is same as Object name then action
            if (hit.collider.name == this.name) Jump();
        }
    }

 
        //ABSTRACTION implementation
        protected virtual void Refresh() 
    {
        childObject.transform.root.GetComponentInParent<Renderer>().material.color = color;
        childObject.GetComponent<TextMesh>().text = poruka;
    }
    
}
