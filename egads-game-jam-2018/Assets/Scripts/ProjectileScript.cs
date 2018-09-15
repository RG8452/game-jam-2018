using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
	public float moveSpeed;

	void Awake()
	{
	}

	void Start()
	{
		moveSpeed = 1f;
	}

	void Update()
	{
		float moveHorizontal = moveSpeed * Time.deltaTime;

		transform.Translate(new Vector3(moveHorizontal, 0, 0));
	}
}
