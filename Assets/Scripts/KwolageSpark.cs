using UnityEngine;
using System.Collections;

public class KwolageSpark : MonoBehaviour {
	public GameObject rightbutton;
	private Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(){
		anim = (rightbutton.GetComponent<Animator>()) ;
		anim.enabled = true;
	}
	void OnTriggerExit2D(){
		anim = (rightbutton.GetComponent<Animator>()) ;
		anim.enabled = false; 
	}
}
