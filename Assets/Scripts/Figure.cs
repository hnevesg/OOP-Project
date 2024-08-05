using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    private float h;
    private float w;

    public float height
    {
        get { return h; }
        protected set
        {
            if (value > 0)
            {
                h = value;
            }
        }
    }
    public float width 
    { 
        get { return w; }
        protected set
        {
            if (value > 0)
            {
                w = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Info(){
        Debug.Log("It's a figure");
    }

    void OnMouseDown()
    {
        Info();
        Debug.Log("Height: " + height);
        Debug.Log("Width: " + width);
    }
}
