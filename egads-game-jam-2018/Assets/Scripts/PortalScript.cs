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
        portals = new GameObject[] {GameObject.Find("Portal"), GameObject.Find("Portal (1)"),
                                    GameObject.Find("Portal (2)"), GameObject.Find("Portal (3)") };
		projectile = Instantiate(projectilePrefab);

	}

	void Update()
	{
		
	}
}
