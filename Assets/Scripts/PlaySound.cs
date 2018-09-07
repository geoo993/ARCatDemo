using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button), typeof(AudioSource))]
public class PlaySound : MonoBehaviour {

    public AudioClip sound;
    private Button button {
        get {
            return GetComponent<Button>();
        }
    }
    private AudioSource audioSource {
        get {
            return GetComponent<AudioSource>();
        }
    }
    
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.playOnAwake = false;

        button.onClick.AddListener(() => PlayAudioClip());
	}
    
    void PlayAudioClip() {
    
        if (audioSource.isPlaying) {
            audioSource.Stop();
        }
        
        audioSource.PlayOneShot(sound);
    }
}
