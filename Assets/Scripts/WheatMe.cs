using UnityEngine;
using System.Collections;

public class WheatMe : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddShells(float amount){
		amount = PlayerPrefsManager.GetCurrencyAmount ();
		amount = (amount + 10f);
		PlayerPrefsManager.SetCurrencyAmount (amount);
		print (PlayerPrefsManager.GetCurrencyAmount ());

	}

	public void PlayAudio(){
		audioSource.Play ();
	}
}
