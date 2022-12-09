using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    public InputField userInput;
    public Text gameText;
    public Button gameButton;
    public int minValue;
    public int maxValue;
    private bool winCondition = false;
    private int angkaAcak;
    // Start is called before the first frame update
    void Start()
    {
        gameReset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int GetRandomNum(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }
    private void gameReset()
    {
        if(winCondition)
        {
            gameText.text = "Kamu menang! Tebak angka yang lain dari " + minValue + " sampai " + maxValue;
            winCondition = false;
        }
        else
        {
            gameText.text = "Tebak angka dari " + minValue + " sampai " + maxValue;
        }
        userInput.text = "";
        angkaAcak = GetRandomNum(minValue, maxValue);
    }
    public void tombolGame()
    {
        string userInputNumber = userInput.text;
        if(userInputNumber != "")
        {
            int answer = int.Parse(userInputNumber);
            if(answer == angkaAcak)
            {
                gameText.text = "Anda menebak angka yang benar!";
                winCondition = true;
                gameReset();
            }
            else if(answer > angkaAcak)
            {
                gameText.text = "Sedikit lebih kecil";
            }
            else
            {
                gameText.text = "Sedikit lebih besar";
            }
        }
        else
        {
            gameText.text = "Masukkan angka yang benar";
        }
    }
}
