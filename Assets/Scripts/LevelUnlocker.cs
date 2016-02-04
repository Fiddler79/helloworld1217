using UnityEngine;
using System.Collections;

public class LevelUnlocker : MonoBehaviour {
    public GameObject[] LevelArray;
	
    // Use this for initialization
	void Start () {
		if (PlayerPrefsManager.IsLevelUnlocked (9)) 
		{
			LevelArray [0].SetActive (true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (10))
		{
			LevelArray [1].SetActive (true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (11)) 
		{
			LevelArray [2].SetActive (true);
		}
	
		if (PlayerPrefsManager.IsLevelUnlocked (12))
		{
			LevelArray[3].SetActive(true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (13))
		{
			LevelArray[4].SetActive(true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (14))
		{
			LevelArray[5].SetActive(true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (15))
		{
			LevelArray[6].SetActive(true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (16))
		{
			LevelArray[7].SetActive(true);
		}
		if (PlayerPrefsManager.IsLevelUnlocked (17))
		{
			LevelArray[8].SetActive(true);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
