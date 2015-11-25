using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {
	
	private Animator anim;
	private Attacker attacker;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay2D (Collider2D collider) {
		GameObject obj = collider.gameObject;
		
		// Leave the method if not colliding with defender
		if (!obj.GetComponent<Defender>() && !obj.GetComponent<MovingDefender>()) {
			return;
		}
		
		anim.SetBool ("isAttacking", true);
		attacker.Attack (obj);

	}
	public void PlayAudio(){
		audioSource.Play ();
	}
}
