using UnityEngine;
using System.Collections;

[RequireComponent (typeof (MovingDefender))]
public class Caveman : MonoBehaviour {
			
		private Animator anim;
		private MovingDefender attacking;
		
		// Use this for initialization
		void Start () {
			anim = GetComponent<Animator>();
			attacking = GetComponent<MovingDefender>();
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		void OnTriggerStay2D (Collider2D thiscollider) {

			GameObject obj = thiscollider.gameObject;

			// Leave the method if not colliding with attacker
			if (!obj.GetComponent<Attacker>()) {
				return;
			}
			
			anim.SetBool ("IsAttacking", true);
			
		attacking.MyAttack (obj);

	}
	}

	
