using UnityEngine;
using System.Collections;

public class MusicButton : MonoBehaviour {
	private StarDisplay starDisplay;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		print ("i've been clicked!");
		anim.SetBool ("BeenClicked", true);

	}

	void SetFalse(){
		anim.SetBool ("BeenClicked", false);
	}

}
