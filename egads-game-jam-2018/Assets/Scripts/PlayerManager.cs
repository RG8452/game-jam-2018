﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int lives = 3;


	void Start()
	{
		
	}

	void Update()
	{
	}

    void OnCollisionEnter(Collision col)
    {
        lives--;
        Destroy(col.gameObject);

		if(lives <= 0)
		{
			Destroy(gameObject);
		}
    }
}
