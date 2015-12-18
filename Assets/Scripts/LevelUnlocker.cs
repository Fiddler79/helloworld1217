using UnityEngine;
using System.Collections;

public class LevelUnlocker : MonoBehaviour {
    public GameObject[] LevelArray;
	
    // Use this for initialization
	void Start () {
          if (PlayerPrefsManager.IsLevelUnlocked (2)) {
            LevelArray[0].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
