using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    
    TimerSlider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<TimerSlider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.onCooldown || slider.person.GetComponent<Status>().isBusy)
            GetComponent<Button>().interactable = false;
        else
            GetComponent<Button>().interactable = true;
    }
   
}
