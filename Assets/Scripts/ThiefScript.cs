using UnityEngine;
using System.Collections;

public class ThiefScript : MonoBehaviour {

	private Animator anim;
	public GameObject[] dinoPrefabArray;

	void Start() {
		anim = GetComponent<Animator>();
	}

	void Update () {

		foreach (GameObject thisDino in dinoPrefabArray) {
			if (isTimeToSpawn (thisDino)) {
				anim.SetTrigger  ("Bring the dino");
			}
		}	

	}

	void OnMouseDown () {
		anim.SetTrigger  ("Playerhithead");
	}

	
	bool isTimeToSpawn (GameObject DinoGameObject) {
			
		float meanSpawnDelay = 7.5f;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning ("Spwan rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime / 5;
		
		return (Random.value < threshold);
	}
}
