using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Button[] buttons;
    public Text[] texts;
    public GameObject questionMark;
    public GameObject inventoryText;
    public GameObject wordPanel;
    public GameObject sidePanel;
    public GameObject catObject;
    private float distanceToCamera = 1.0f;

    private void Start()
    {
        DisableButtons();
    }
    
    public void WordCorrect () {
        StartCoroutine(WaitThenDisable());
	}
    
    IEnumerator WaitThenDisable(){
        inventoryText.SetActive(false);
        questionMark.SetActive(false);
        WordPanelColor();
        yield return new WaitForSeconds (2.0f);
        wordPanel.SetActive(false);
        EnableButtons();
        InstantiateCat();
    }
    
    void WordPanelColor() {

        Color color = wordPanel.GetComponent<Image>().color;
        color.a = 0.0f;
        wordPanel.GetComponent<Image>().color = color;
    }
    
    void DisableButtons() {

        foreach (Button button in buttons)
        {
            button.interactable = false;
            button.enabled = false;
        }

        foreach (Text text in texts)
        {
            Color color = text.color;
            color.a = 0.2f;
            text.color = color;
        }
    }
    
    void EnableButtons() {
        foreach (Button button in buttons)
        {
            button.interactable = true;
            button.enabled = true;
        }
        
        foreach (Text text in texts)
        {
            Color color = text.color;
            color.a = 1.0f;
            text.color = color;
        }
    }

    void InstantiateCat() {
    
        GameObject item = (GameObject)Instantiate( catObject );
        item.transform.position = Camera.main.transform.position + Camera.main.transform.forward * distanceToCamera;
        item.transform.rotation = new Quaternion( 0.0f, Camera.main.transform.rotation.y, 0.0f, Camera.main.transform.rotation.w );
    }

}
