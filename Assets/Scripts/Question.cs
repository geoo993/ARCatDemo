using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
    
        Debug.Log ("Trigger Enter" + collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
         Debug.Log ("Trigger Exit" + collision.name);
    }
}
