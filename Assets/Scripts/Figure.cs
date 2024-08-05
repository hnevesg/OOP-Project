using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    private float h;
    private float w;

    protected float height
    {
        get { return h; }
        set
        {
            if (value > 0)
            {
                h = value;
            }
        }
    }
    protected float width 
    { 
        get { return w; }
        set
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
        Info();
        Debug.Log("Height: " + height);
        Debug.Log("Width: " + width);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Info(){
        Debug.Log("It's a figure");
    }
}
