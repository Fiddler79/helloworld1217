using UnityEngine;
using System.Collections;

public class Shreddder : MonoBehaviour {

	void OnTriggerStay2D (Collider2D collider) {
		GameObject obj = collider.gameObject;
		
		// Leave the method if not colliding with defender
		if (obj.GetComponent<Attacker> ()) {
			return;
		} else {

			Destroy (collider.gameObject);
		}
	}
	
}
