using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour {

    public GameObject infoPanel;
    private bool toggle = false;
    private Color originalColor;
    
	// Use this for initialization
	void Start () {
        originalColor = GetComponent<Image>().color;
        infoPanel.SetActive(false);
	}

    public void ShowInfo () 
    {
       
        if(!toggle)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, originalColor.a);
            infoPanel.SetActive(true);
            toggle = true;
        }
        else 
        {
            GetComponent<Image>().color = originalColor;
            infoPanel.SetActive(false);
            toggle = false;
        }
    }
}
