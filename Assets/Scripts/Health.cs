using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public float health = 100f;
	private Animator anim;

	public void Start(){

		anim = GetComponent<Animator>();
	
	}
	public void DealDamage (float damage) {
		health -= damage;
		if (health < 0) {
			if (!GetComponent<Lizard>()){
				// Optionally trigger animation
				DestoryObject ();
			}else{
			anim.SetBool ("isDead", true);
			}
		}
	}
	
	public void DestoryObject () {
		Destroy (gameObject);
	}
	
}
