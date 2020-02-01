using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
	[SerializeField] private float elapsedTime = 0.0f;
	[SerializeField] private float timeToSpawn = 3.0f;

	[SerializeField] private GameObject fishObject = null;
	[SerializeField] private GameObject bottleObject = null;

	[SerializeField] private float fishThreshold = 70.0f;
	[SerializeField] private float bottleThreshold = 20.0f;

    [SerializeField] private Transform placeToSpawn = null;
    [SerializeField] private Transform maxY = null;
    [SerializeField] private Transform minY = null;

    void Update () {
		elapsedTime += Time.deltaTime;
		if (elapsedTime >= timeToSpawn) {
            SpawnObject();
		}
	}

	void SpawnObject(){
        Vector2 positionToSpawn = new Vector2(placeToSpawn.position.x, Random.Range(minY.transform.position.y, maxY.transform.position.y));
		float randomNumber = Random.Range (0.0f, 100.0f);

		if (randomNumber < fishThreshold) {
            Instantiate(fishObject, positionToSpawn, Quaternion.identity);
		}

        else
        {
            Instantiate(bottleObject, positionToSpawn, Quaternion.identity);
        }

        elapsedTime = 0.0f;
    }
}
