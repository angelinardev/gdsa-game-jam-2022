using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    [Range(0,4)]
    public int burnout;
    [Range(0,4)]
    public int food;
    [Range(0,4)]
    public int sleep;
    [Range(0,4)]
    public int motivation;
    public bool isBusy = false;

    ChangeScene change;

    // Start is called before the first frame update
    void Start()
    {
        change = GameObject.FindGameObjectWithTag("GameController").GetComponent<ChangeScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
        /* if (burnout == 4 || food ==0 || sleep ==0 ||motivation ==0)
        {
            //end game!
        } */
    }
    public void ChangeBurnout(int n)
    {
        burnout += n;
        if (burnout >4)
        {
           //set end game
           change.GameOver();
           
           
           burnout = 4;
        }
        if (burnout < 0)
        {
            burnout = 0;
        }
    }
    public void ChangeFood(int n)
    {
        food += n;
        if (food >4)
        {
            food = 4;
        }
        if (food < 0)
        {
           //set end game
            change.GameOver();
           food = 0;
        }
    }
    public void ChangeSleep(int n)
    {
        sleep += n;
         if (sleep >4)
        {
            sleep = 4;
        }
        if (sleep < 0)
        {
            //set end game
             change.GameOver();
            sleep = 0;
        }
    }
    public void ChangeMotivation(int n)
    {
        motivation += n;
         if (motivation >4)
        {
            motivation = 4;
        }
        if (motivation < 0)
        {
            //set end game
             change.GameOver();
            motivation = 0;
        }
    }
    
}
