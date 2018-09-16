using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Quaternion endRotation;
	public float rotSpeed;


	void Start()
	{
		rotSpeed = 10f;
    }

	void Update()
	{
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
			endRotation = Quaternion.Euler(0, 0, 90);
		}
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			endRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
			endRotation = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
			endRotation = Quaternion.Euler(0, 0, 180);
        }

		this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation, rotSpeed * Time.deltaTime);
    }
}
