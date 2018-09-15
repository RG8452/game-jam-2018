using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private int counter = 0;

	void Start()
	{
		
	}
	
	void Update()
	{
		
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        ++counter;
    }

    public int getBlockCount()
    {
        return counter;
    }
}
