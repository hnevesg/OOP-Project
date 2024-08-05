using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public int nFigures;
    private Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartGame()
    {
        try{
            nFigures = Convert.ToInt32(inputField.text);
            if(nFigures > 0)
            {
                inputField.textComponent.color = Color.black;
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
            }else{
                Debug.Log("Number must be greater than 0");
                inputField.textComponent.color = Color.red; 
            }
        }catch(Exception e){
            inputField.textComponent.color = Color.red; 
            Debug.Log(e);
        }
    }
}
