using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
   [Range(0, 100)]
   public int progressPercent;

    public GameObject progressBar;

    Image barTransform;

    // Start is called before the first frame update
    void Start()
    {
        barTransform = progressBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barTransform.fillAmount = (float)progressPercent / 100f;

    }
    public void IncreaseProgress(int n) {
        progressPercent +=n;
    }
}
