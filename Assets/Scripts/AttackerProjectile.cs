using UnityEngine;
using System.Collections;

public class AttackerProjectile : MonoBehaviour {

	public float speed, damage;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D collider) {
		MovingDefender  defender = collider.gameObject.GetComponent<MovingDefender>();
		Health health = collider.gameObject.GetComponent<Health>();

		if (defender && health) {
			health.DealDamage (damage);
			Destroy (gameObject);
		}
	}
}
