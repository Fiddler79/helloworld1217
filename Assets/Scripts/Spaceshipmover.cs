using UnityEngine;
using System.Collections;

public class Spaceshipmover : MonoBehaviour {

	public float speed = 1.5f;
	private Vector3 target;
	private Animator animator;

	float xmax = 1600f;
	float xmin = 1f;
	float ymin = 5f;
	float ymax = 900f;

	void Start () {
		animator = GetComponent<Animator> ();
		target = transform.position;

	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = transform.position.z;
			animator.SetBool ("Player Clicked", true);
			StartCoroutine("continuemovement");
		}

		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		//restrict player to game space
		float newX = Mathf.Clamp (transform.position.x, xmin, xmax);
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
		float newY = Mathf.Clamp (transform.position.y, ymin, ymax);
		transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		} 

	IEnumerator continuemovement(){
		yield return new WaitForSeconds (1.3f);
		animator.SetBool ("Player Clicked", false);

		}
}