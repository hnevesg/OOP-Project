using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Square : Figure
{
    public void Initialize(float h, float w)
    {
        height = h;
        width = w;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    public override void Info(){
        Debug.Log("It's a square");
    }

    void OnMouseDown()
    {
        Info();
        Debug.Log("Height: " + height);
        Debug.Log("Width: " + width);
    }
}
