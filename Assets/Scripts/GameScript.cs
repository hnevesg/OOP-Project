using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private int nFigures;
    // Start is called before the first frame update
    void Start()
    {
        nFigures = Convert.ToInt32(TitleScript.inputField.text);
    }

    // Update is called once per frame
    void Update()
    {
        //create nFigures figures of types Circle and Square with random color and size through time
        for (int i = 0; i < nFigures; i++)
        {
            generateFigure();
            if (i % 2 == 0)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

/*
   public GameObject circlePrefab;

    public void InitializeCircle()
    {
        if (randomNumber() % 2 == 0)
        {
            GameObject circleObject = Instantiate(circlePrefab);
            Circle circle = circleObject.AddComponent<Circle>();
            SetCircleDimensions(circle, UnityEngine.Random.Range(1, 10), UnityEngine.Random.Range(1, 10));
            circle.gameObject.GetComponent<Renderer>().material.color = randomColor();
        }
    }
*/
    Figure generateFigure(){
        if (randomNumber() % 2 == 0)
        {
            float height = UnityEngine.Random.Range(1.0f, 10.0f);
            float width = UnityEngine.Random.Range(1.0f, 10.0f);
            Circle circle = new Circle(height, width);
            circle.gameObject.GetComponent<Renderer>().material.color = randomColor();
            return circle;
        }
        else
        {
            float height = UnityEngine.Random.Range(1.0f, 10.0f);
            float width = UnityEngine.Random.Range(1.0f, 10.0f);
            Square square = new Square(height, width);
            square.gameObject.GetComponent<Renderer>().material.color = randomColor();
            return square;
        }
    }

    int randomNumber()
    {
        return UnityEngine.Random.Range(1, 10);
    }

    Color randomColor()
    {
        return new Color(UnityEngine.Random.Range(0, 1), UnityEngine.Random.Range(0, 1), UnityEngine.Random.Range(0, 1));
    }
}
