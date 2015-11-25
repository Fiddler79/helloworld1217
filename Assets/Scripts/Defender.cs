using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	
	public int starCost = 100;
	private AudioSource audioSource;
	private StarDisplay starDisplay;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

	public void PlayAudio(){
		audioSource.Play ();
	}

	// Only being used as a tag for now!
	public void AddStars (int amount) {
		starDisplay.AddStars (amount);
	}
}
