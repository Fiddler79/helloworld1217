using UnityEngine;
using System.Collections;


public class Traptree : MonoBehaviour {

			
		private GameObject currentTarget;
		private Animator animator;
		
		void Start () {
			animator = GetComponent<Animator>();
		}
		
		// Update is called once per frame
		void Update () {
			
			if (currentTarget) {
			if (currentTarget.GetComponent<MovingDefender>() ){
				return;
			}
				animator.SetBool ("IsAttacking", true);
			}
		}
		
		
		void OnTriggerEnter2D (Collider2D collider) {
		currentTarget = collider.gameObject;
		}
		
		
		// Called from the animator at time of actual blow
		public void  StrikeCurrentTarget (float damage) {
		if (!currentTarget.GetComponent<Mammoth> ()) {
			if (currentTarget) {

				Health health = currentTarget.GetComponent<Health> ();
				
				if (health) {
					health.DealDamage (damage);
					
				}
			}
		}
	}
	}
