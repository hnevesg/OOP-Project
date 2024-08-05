using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private int nFigures;
    public GameObject sphere;
    public GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        nFigures = Convert.ToInt32(TitleScript.inputField.text);
        StartCoroutine(FiguresCoroutine());       
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator FiguresCoroutine(){
        for (int i = 0; i < nFigures; i++)
        {
            generateFigure();
            if (i % 2 == 0)
            {
                yield return new WaitForSeconds(1);
            }
        }
    }

    GameObject generateFigure(){
        if (randomNumber() % 2 == 0)
        {
            GameObject sphereInstance = Instantiate(sphere, new Vector3(randomNumber(), randomPositiveNumber(), randomNumber()), Quaternion.identity);
            Circle circle = sphereInstance.AddComponent<Circle>();
            float height = UnityEngine.Random.Range(1.0f, 10.0f);
            float width = UnityEngine.Random.Range(1.0f, 10.0f);
            circle.Initialize(height, width);
            sphereInstance.GetComponent<Renderer>().material.color = randomColor();
            return sphereInstance;
        }
        else
        {
            GameObject cubeInstance = Instantiate(cube, new Vector3(randomNumber(), randomPositiveNumber(), randomNumber()), Quaternion.identity);
            Square square = cubeInstance.AddComponent<Square>();
            float height = randomPositiveNumber();
            float width = randomPositiveNumber();
            square.Initialize(height, width);
            cubeInstance.transform.localScale = new Vector3(square.width, square.height, 1); 
            cubeInstance.gameObject.GetComponent<Renderer>().material.color = randomColor();
            return cubeInstance;
        }
    }

    int randomPositiveNumber()
    {
        return UnityEngine.Random.Range(1, 5);
    }

    int randomNumber()
    {
        return UnityEngine.Random.Range(-8, 9);
    }

    Color randomColor()
    {
        int random = UnityEngine.Random.Range(0, 5);
        switch (random)
        {
            case 0:
                return Color.red;
            case 1:
                return Color.green;
            case 2:
                return Color.blue;
            case 3:
                return Color.yellow;
            case 4:
                return Color.black;
        }
        return Color.white;
    }
}
