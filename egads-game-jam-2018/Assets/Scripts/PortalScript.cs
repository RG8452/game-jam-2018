using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
	public GameObject[] portals;
	public GameObject projectilePrefab;
	GameObject projectile;

	void Start()
	{
		portals = GameObject.FindGameObjectsWithTag("Portal");
		int point = Random.Range(0, portals.Length - 1);
		GameObject spawnPoint = portals[point];
		projectile = Instantiate(projectilePrefab);

	}

	void Update()
	{
		
	}
}
