using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Events : MonoBehaviour { 
    public Status status;
    public float RandomEventHappMin = 33.3f;
    public float RandomEventHappMax = 60.0f;
    private float timer;
    delegate void RandomEvents();

    public Button button;

    //Make a list of Events
    List<RandomEvents> randEvents = new List<RandomEvents>();

    RandomEvents currentEvent;

    public GameObject[] people;

    void EventNames()
    {
        
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
         if (!status.isBusy)
        {status.motivation = status.motivation + 1;
        status.sleep = status.sleep - 2;
        status.food = status.food - 1;

        //button was clicked in all these cases
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void WalkingAround()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation + 2;
        status.sleep = status.sleep - 2;
        status.food = status.food - 2;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void Eating()
    {
         if (!status.isBusy)
        {status.food = status.food + 4;
        status.sleep = status.sleep - 3;
        status.motivation = status.motivation + 1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void Praying()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation + 1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void Distraction()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation + 1;
        status.food = status.food - 1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void SideQuests()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation - 1;
        status.sleep = status.sleep - 1;
        status.food = status.food - 1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void Napping()
    {
         if (!status.isBusy)
        {status.sleep = status.sleep + 1;
        status.food = status.food + 1;
        status.motivation = status.motivation = -1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void Sleeping()
    {
         if (!status.isBusy)
        {status.sleep = status.sleep + 4;
        status.food = status.food + 4;
        status.motivation = status.motivation - 3;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }

    public void SocialMediaScroll()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation - 2;
        status.food = status.food - 1;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
        
    }

    public void Depression()
    {
         if (!status.isBusy)
        {status.motivation = status.motivation - 3;
        status.food = status.food - 2;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
         SetBusy();
        }
    }


    public void LaptopMalfunction()
    {
        if (!status.isBusy)
        {status.motivation = status.motivation - 4;
        status.sleep = status.sleep - 2;
        status.food = status.food - 2;
        //make button invisible
        button.GetComponent<CanvasGroup>().alpha = 0;
        SetBusy();
        }
    }
    public void SetBusy()
    {
        status.isBusy = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(RandomEventHappMin, RandomEventHappMax);
        //setup events
        EventNames();
        //get the status to start
        status = people[0].GetComponent<Status>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);
        if(timer <= 0f)
        {
            timer = Random.Range(RandomEventHappMin, RandomEventHappMax);
            ChooseEvent();
          
        }
    }

    void ChooseEvent()
    {
        //make previous person finish
        status.isBusy = false;
        //choose person for event
        int index2 = Random.Range(0, people.Length-1);
        status = people[index2].GetComponent<Status>();

        //Debug.Log(status.gameObject.name);
        
        //reset button
        button.onClick.RemoveAllListeners();
        
        int index = Random.Range(0, randEvents.Count-1);
        //make button visible
        button.GetComponent<CanvasGroup>().alpha = 1;

        //Debug.Log(index);

        //manual solution for now
        switch (index)
        {
            case 0:
                button.onClick.AddListener(VideoGames);
                button.GetComponentInChildren<TMP_Text>().text = "Video Games " + status.gameObject.name;
                
                break;
            case 1:
                button.onClick.AddListener(WalkingAround);
                button.GetComponentInChildren<TMP_Text>().text = "walking around " + status.gameObject.name;
                break;
            case 2:
                button.onClick.AddListener(Eating);
                button.GetComponentInChildren<TMP_Text>().text = "eating " + status.gameObject.name;
                break;
            case 3:
                button.onClick.AddListener(Praying);
                button.GetComponentInChildren<TMP_Text>().text = "praying " + status.gameObject.name;
                break;
            case 4:
                button.onClick.AddListener(Napping);
                button.GetComponentInChildren<TMP_Text>().text = "napping " + status.gameObject.name;
                break;
            case 5:
                button.onClick.AddListener(Sleeping);
                button.GetComponentInChildren<TMP_Text>().text = "sleeping " + status.gameObject.name;
                break;
            case 6:
                button.onClick.AddListener(Distraction);
                button.GetComponentInChildren<TMP_Text>().text = "distraction " + status.gameObject.name;
                break;
            case 7:
                button.onClick.AddListener(SocialMediaScroll);
                button.GetComponentInChildren<TMP_Text>().text = "social media scroll " + status.gameObject.name;
                break;
            case 8:
                button.onClick.AddListener(LaptopMalfunction);
                button.GetComponentInChildren<TMP_Text>().text = "laptop malfunction " + status.gameObject.name;
                break;
            case 9:
                button.onClick.AddListener(Depression);
                button.GetComponentInChildren<TMP_Text>().text = "depression " + status.gameObject.name;
                break;
            case 10:
                button.onClick.AddListener(SideQuests);
                button.GetComponentInChildren<TMP_Text>().text = "Side quests " + status.gameObject.name;
                break;
            default:
                break;
        }
       
        
        
    }
}
