using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
   [Header("Component")]
   public TextMeshProUGUI timerText;
  

    [Header("Timer Settings")]
    public float currentTime = 10.0f;
    public bool countDown;

    [Header ("Limit Settings")]
    public bool hasLimit;
    public float timerLimit; 


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
       if(currentTime > 0)
        {
            currentTime -= Time.deltaTime / 60 ;
        }

        double roundto2 = System.Math.Round(currentTime,0);
        timerText.text = roundto2.ToString() + " Hrs";

        if (currentTime < 0)
        {
            SetTimerText();
            //End game
        }
    }
  
    private void SetTimerText()
    {
        //set how many decimal points
        timerText.text = currentTime.ToString("0.0");
    }
}
