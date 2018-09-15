using System.Collections;
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
        Destroy(col.gameObject);
        Destroy(this);
    }
}
