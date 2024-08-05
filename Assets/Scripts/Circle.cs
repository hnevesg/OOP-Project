using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Circle : Figure
{
    // Start is called before the first frame update
    public void Initialize(float h, float w)
    {
        height = h;
        width = w;
    }   

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    public override void Info(){
        Debug.Log("It's a circle");
    }

    void OnMouseDown()
    {
        Info();
        Debug.Log("Height: " + height);
        Debug.Log("Width: " + width);
    }
}
