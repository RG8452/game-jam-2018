using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScript : MonoBehaviour
{
	PlayerManager pManagerScript;

	public GameObject[] lives;

	void Start()
	{
		pManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
	}

	void Update()
	{

	}
}
