﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    int health;


	void Start()
	{
		
	}

	void Update()
	{
		
	}
    void OnCollisionEnter(Collision col)
    {
        --health;
        //Debug.Log(col.gameObject.name);
        Destroy(col.gameObject);
        
    }
}
