using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpecialTimer : MonoBehaviour {

	public float levelSeconds = 100;

	private Slider slider;
	private AudioSource audioSource;
	private bool isEndOfLevel = false;
	private LevelManager levelManager;
	private GameObject winLabel;
	private StarDisplay starDisplay;
	public int winCost = 150;

	// Use this for initialization
	void Start () {

		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		FindYouWin ();
		winLabel.SetActive(false);
	}

	void FindYouWin ()
	{
		winLabel = GameObject.Find ("You Win");
		if (!winLabel) {
			Debug.LogWarning ("Please create You Win object");
		}
	}

	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;

		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if (timeIsUp && !isEndOfLevel) {
			if (starDisplay.UseStars (winCost) == StarDisplay.Status.SUCCESS) {
				HandleWinCondition ();
			} else if (starDisplay.UseStars (winCost) == StarDisplay.Status.FAILURE) {
				levelManager.LoadLevel ("03b Lose");
			}
		}
	}

	void HandleWinCondition ()
	{
		DestroyAllTaggedObjects();
		audioSource.Play ();
		UnlockLevel();
		winLabel.SetActive (true);
		Invoke ("LoadNextLevel", audioSource.clip.length);
		isEndOfLevel = true;
	}

	// Destroys all objects with destroyOnWin tag
	void DestroyAllTaggedObjects() {
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag ("destroyOnWin");

		foreach (GameObject taggedObject in taggedObjectArray) {
			Destroy (taggedObject);
		}
	}

	void LoadNextLevel () {

		levelManager.LoadLevel ("03a Win") ;

	}
	void UnlockLevel()
	{

		print(Application.loadedLevel);
		int LevelCounter = (Application.loadedLevel + 1);
		print(LevelCounter);
		PlayerPrefsManager.UnlockLevel(LevelCounter);
		print("unlocked level " + LevelCounter);

	}
}