using UnityEngine;
using System.Collections;


public class RangedFoe : MonoBehaviour {
	 
	private Animator anim;
	private Attacker attacking;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacking = GetComponent<Attacker>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D (Collider2D thiscollider) {

		GameObject obj = thiscollider.gameObject;

		// Leave the method if not colliding with attacker
		if (!obj.GetComponent<Defender>() && !obj.GetComponent<MovingDefender>())
		{
			return;
		}

		anim.SetBool ("isAttacking", true);

		attacking.Attack (obj);

	}
}


