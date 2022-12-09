using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    public Text timeField;
    private float time;
    private string[] wordsLocal = {"SAPI", "MACAN", "KUCING", "HARIMAU", "KELINCI"};
    private int[] myNums = {8, 7, 6, 5, 4};
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 10; i > 0; i-=2)
        {
            Debug.Log(i);
        }
        Debug.Log("Done with the loop");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeField.text = time.ToString();
    }
}
