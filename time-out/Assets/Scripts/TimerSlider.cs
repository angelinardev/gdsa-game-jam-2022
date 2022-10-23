using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerSlider : MonoBehaviour
{
   
    public Slider timerSlider;
     public TextMeshProUGUI timerText;
     //how long it takes to do this, in seconds
     public float gameTime;
     private bool stopTimer;

     public bool activate;

    public bool onCooldown = false;

    public Button[] otherActions;

    public float currentTime;

    

    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        activate = false;
        timerSlider.enabled = false;
        currentTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (activate)
        {
            DoTimer();
           
        }
        
       
    }
    public void Activate()
    {
       
        activate = true;
        for (int i=0; i < otherActions.Length; i++)
        {
            //cannot activate if another is on cooldown
            if (otherActions[i].GetComponent<TimerSlider>().onCooldown)
                activate = false;
        }
        timerSlider.enabled = true;
        

    }
    public void DoTimer()
    {
        //float time = gameTime- Time.time;
        currentTime -= Time.deltaTime;
        //Debug.Log(currentTime);

        //int minutes = Mathf.FloorToInt(currentTime/60);
        //int seconds = Mathf.FloorToInt(currentTime - minutes *60f);

         timerText.text = currentTime.ToString("0.0");
        timerSlider.value = currentTime;
        onCooldown = true;
        
        if (currentTime <= 0)
        {
            currentTime = gameTime;
            timerText.text = currentTime.ToString("0.0");
            timerSlider.value = currentTime;
            //timerText.color = Color.red;

            Reset();
            //enabled = false;
        } 
       

        /* //string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        string textTime = currentTime.ToString("0.0");
        if (currentTime <=0)
        {
            stopTimer = true;
            onCooldown = false;
            Reset();
            return;
            //need to reset
        }
        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = currentTime;
            onCooldown = true;
        } */
    }
    public void Reset()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        activate = false;
        timerSlider.enabled = false;
        onCooldown = false;
        currentTime = gameTime;
    }

}
