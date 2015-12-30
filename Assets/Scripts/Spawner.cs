using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject thisSpawner;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter2D (Collider2D collider){


        // the game object is what im colliding with 

        GameObject obj = collider.gameObject;
        if (!obj.GetComponent<rangedattackerhitbox>())
        {
            obj.transform.parent = thisSpawner.transform;
        }
    }
}

