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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeBurnout(int n)
    {
        burnout += n;
    }
    void ChangeFood(int n)
    {
        food += n;
    }
    void ChangeSleep(int n)
    {
        sleep += n;
    }
    void ChangeMotivation(int n)
    {
        motivation += n;
    }
}
