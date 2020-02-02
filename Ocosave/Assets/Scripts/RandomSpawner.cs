﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
	[SerializeField] private float elapsedTime = 0.0f;
    [SerializeField] private float timeToSpawnMin = 1.0f;
    [SerializeField] private float timeToSpawnMax = 3.0f;

	[SerializeField] private GameObject[] fishObject = null;
	[SerializeField] private GameObject[] trashObject = null;

	[SerializeField] private float fishThreshold = 70.0f;
    [SerializeField] private Transform placeToSpawn = null;
    [SerializeField] private Transform maxY = null;
    [SerializeField] private Transform minY = null;


    void Update () {
		elapsedTime += Time.deltaTime;
		if (elapsedTime >= Random.Range(timeToSpawnMin,timeToSpawnMax)) {
            SpawnObject();
		}
	}

	void SpawnObject(){
        Vector2 positionToSpawn = new Vector2(placeToSpawn.position.x, Random.Range(minY.transform.position.y, maxY.transform.position.y));
		float randomNumber = Random.Range (0.0f, 100.0f);

		if (randomNumber < fishThreshold) {
            int randomfIndex = Random.Range(0, fishObject.Length);
            Instantiate(fishObject[randomfIndex], positionToSpawn, Quaternion.identity);
		}

        else
        {
            int randomtIndex = Random.Range(0, trashObject.Length);
            Instantiate(trashObject[randomtIndex], positionToSpawn, Quaternion.identity);
        }

        elapsedTime = 0.0f;
    }
}