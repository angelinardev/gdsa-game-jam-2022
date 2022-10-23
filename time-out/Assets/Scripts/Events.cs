using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Events : MonoBehaviour { 
    public Status status;
    public float RandomEventHappMin = 33.3f;
    public float RandomEventHappMax = 60.0f;
    private float timer;
    delegate void RandomEvents();
    void EventNames()
    {
        //Make a list of Events
        List<RandomEvents> randEvents = new List<RandomEvents>();
        randEvents.Add(VideoGames);
        randEvents.Add(WalkingAround);
        randEvents.Add(Eating);
        randEvents.Add(Praying);
        randEvents.Add(Napping);
        randEvents.Add(Sleeping);
        randEvents.Add(Distraction);
        randEvents.Add(SocialMediaScroll);
        randEvents.Add(LaptopMalfunction);
        randEvents.Add(Depression);
        randEvents.Add(SideQuests);


        //Call Event
        
    }
    


    public void VideoGames()
    {
        status.motivation = status.motivation + 1;
        status.sleep = status.sleep - 2;
        status.food = status.food - 1;
    }

    public void WalkingAround()
    {
        status.motivation = status.motivation + 2;
        status.sleep = status.sleep - 2;
        status.food = status.food - 2;
    }

    public void Eating()
    {
        status.food = status.food + 4;
        status.sleep = status.sleep - 3;
        status.motivation = status.motivation + 1;
    }

    public void Praying()
    {
        status.motivation = status.motivation + 1;
    }

    public void Distraction()
    {
        status.motivation = status.motivation + 1;
        status.food = status.food - 1;
    }

    public void SideQuests()
    {
        status.motivation = status.motivation - 1;
        status.sleep = status.sleep - 1;
        status.food = status.food - 1;
    }

    public void Napping()
    {
        status.sleep = status.sleep + 1;
        status.food = status.food + 1;
        status.motivation = status.motivation = -1;
    }

    public void Sleeping()
    {
        status.sleep = status.sleep + 4;
        status.food = status.food + 4;
        status.motivation = status.motivation - 3;
    }

    public void SocialMediaScroll()
    {
        status.motivation = status.motivation - 2;
        status.food = status.food - 1;
        
    }

    public void Depression()
    {
        status.motivation = status.motivation - 3;
        status.food = status.food - 2;
    }


    public void LaptopMalfunction()
    {
        status.motivation = status.motivation - 4;
        status.sleep = status.sleep - 2;
        status.food = status.food - 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(RandomEventHappMin, RandomEventHappMax);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            timer = Random.Range(RandomEventHappMin, RandomEventHappMax);
          
        }
    }

    void ChooseEvent()
    {

    }
}
