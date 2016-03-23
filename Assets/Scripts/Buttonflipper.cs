using UnityEngine;
using System.Collections;

public class Buttonflipper : MonoBehaviour {
	private Animator anim;
	private int clickcounter = 0;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	void OnMouseDown () {
		if (clickcounter < 1) {
			anim.SetBool ("click2", false);
			anim.SetBool ("clicked", true);
			clickcounter = 2;
		}
		else if (clickcounter > 1) {
			anim.SetBool ("clicked", false);
			anim.SetBool ("click2", true);
			clickcounter = 0;
		}
	}
}

