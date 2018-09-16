using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private GameObject endRotation;
	public float rotSpeed;


	void Start()
	{
		endRotation = new GameObject();
		rotSpeed = 10f;
    }

	void Update()
	{
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
			endRotation.transform.rotation = Quaternion.Euler(0, 0, 90);
		}
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			endRotation.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
			endRotation.transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
			endRotation.transform.rotation = Quaternion.Euler(0, 0, 180);
        }

		this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation.transform.rotation, rotSpeed * Time.deltaTime);
    }
}
