using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameText;
    public Button Tombol;
    public int minValue;
    public int maxValue;
    private bool isGameWon = false;
    //Declare a variable that we want to use
    //then intializing it
    private int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        if(isGameWon)
        {
            gameText.text = "Kamu menang! Tebak angka dari " + minValue + " dan " + (maxValue - 1);
            isGameWon = false;
        }
        else
        {
            gameText.text = "Tebak angka dari " + minValue + " dan " + (maxValue - 1);
        }
        userInput.text = "";
        randomNumber = GetRandomNum(minValue, maxValue);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnButtonClick()
    {
        string userInputValue = userInput.text;
        if (userInputValue != "")
        {
            int Answer = int.Parse(userInputValue);
            if(Answer == randomNumber)
            {
                gameText.text = "Kamu menebak angka yang benar!";
                //Tombol.interactable = false;
                isGameWon = true;
                ResetGame();
            }
            else if(Answer > randomNumber)
            {
                gameText.text = "Coba angka yang lebih kecil";
            }
            else
            {
                gameText.text = "Coba angka yang lebih besar";
            }
        }
        else
        {
            gameText.text = "Masukkan angka yang benar!";
        }
    }

    private int GetRandomNum(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }
}
