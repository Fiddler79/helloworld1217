using UnityEngine;
using System.Collections;

public class ThiefScript : MonoBehaviour {

	public GameObject crops;
	private Animator anim;
	private Animator animother;
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
	void Resetcrops(){
	
	animother = crops.GetComponent<Animator> ();
		animother.SetTrigger ("reset");
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
