using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatusBar : MonoBehaviour
{
    public GameObject person;
    public Material[] textures;
    int index;
    public string target;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (target)
        {
            case "motivation":
                index = person.GetComponent<Status>().motivation;
                break;
            case "food":
                index = person.GetComponent<Status>().food;
                break;
            case "sleep":
                index = person.GetComponent<Status>().sleep;
                break;
            case "burnout":
                index = person.GetComponent<Status>().burnout;
                break;
            default:
                break;
        }
        
        //get the status
        //index = person.GetComponent<Status>().motivation;
        //do minus 1 
        //index -=1;
        //set texture
        //GetComponent<Material>().SetTexture("texture",textures[index]);
        GetComponent<Image>().material = textures[index];
        
        
       
    }
}
