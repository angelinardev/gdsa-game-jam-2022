using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class TargetHighlight : MonoBehaviour
{
    private Renderer render;
    Color original;
    public bool selected = false;

    public GameObject uiGroup;

    
    // Start is called before the first frame update
    void Start()
    {
        render= GetComponent<Renderer>();
        original = render.material.color;
        uiGroup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnMouseEnter() {
       
       render.material.color = Color.red;
       selected = true;
       

    }
    private void OnMouseDown() {
        
        //uiGroup.enabled  = !uiGroup.enabled;
        uiGroup.SetActive(!uiGroup.activeSelf);
    }
    private void OnMouseExit() {
        render.material.color =original;
        selected = false;
    }
}
