using UnityEngine;
using System.Collections;

public class LevelUnlocker : MonoBehaviour {
    public GameObject[] LevelArray;
	
    // Use this for initialization
	void Start () {
          if (PlayerPrefsManager.IsLevelUnlocked (9)) {
            LevelArray[0].SetActive(true);
        }
          if (PlayerPrefsManager.IsLevelUnlocked (10))
        {
            LevelArray[1].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
