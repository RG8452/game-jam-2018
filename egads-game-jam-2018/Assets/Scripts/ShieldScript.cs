using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour {
    private int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        Destroy(col.gameObject);
        ++counter;
    }

    public int getBlockCount()
    {
        return counter;
    }
}
