using UnityEngine;
using System.Collections;

public class Myunlockchecker : MonoBehaviour {

		public GameObject[] LevelArray;
		private BoxCollider2D thisBoxxollide2d;
		private Animator myanim;

	// Use this for initialization
		void Start () {
		myanim = GetComponent<Animator> ();
		LevelArray [0].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [1].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [2].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [3].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [4].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [5].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [6].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [7].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [8].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [9].GetComponent<BoxCollider2D> ().enabled = false;
		LevelArray [10].GetComponent<BoxCollider2D> ().enabled = false;

		if (PlayerPrefsManager.IsLevelUnlocked (19)) { 
		
			LevelArray [0].GetComponent<BoxCollider2D> ().enabled = true;
			LevelArray [0].GetComponent<SpriteRenderer> ().color = Color.black;
			LevelArray [3].GetComponent<BoxCollider2D> ().enabled = true;
			LevelArray [3].GetComponent<SpriteRenderer> ().color = Color.black;
			myanim.SetBool ("level19", true);
			Debug.Log ("I have activated your boxcollider");
		}

	}

		// Update is called once per frame
		void Update () {
		
		}
	}
