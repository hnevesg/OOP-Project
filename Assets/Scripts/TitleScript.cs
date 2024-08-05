using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    public static TMP_InputField inputField;

    // ENCAPSULATION
    private int nFigures;
    private Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        startButton = GetComponent<Button>();
        DontDestroyOnLoad(inputField);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    // ABSTRACTION
    private bool isValidInput(string input, out int count)
    {
        return int.TryParse(input, out count) && count > 0;
    }

    public void StartGame()
    {
       if(isValidInput(inputField.text, out nFigures)){
            inputField.textComponent.color = Color.black;
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }else{
            Debug.Log("Input must be a number greater than 0");
            inputField.textComponent.color = Color.red; 
        }
    }
}
