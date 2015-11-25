using UnityEngine;
using System.Collections;

public class WheatMe : MonoBehaviour {

	// Use this for initialization
	void Start () {

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
}
