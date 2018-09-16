using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
	PlayerManager pManagerScript;
    public Sprite deadheart;
	public GameObject[] lives;
	GameObject temp;
	Image sr;

	void Start()
	{
		pManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
	}

	void Update()
	{
		GameObject temp;
		switch(pManagerScript.lives)
		{
			case 2:
				temp = GameObject.Find("Life Point 1");
				sr = temp.GetComponent<Image>();
				sr.sprite = deadheart;
				break;
			case 1:
				temp = GameObject.Find("Life Point 2");
				sr = temp.GetComponent<Image>();
				sr.sprite = deadheart;
				break;
			case 0:
				temp = GameObject.Find("Life Point 3");
				sr = temp.GetComponent<Image>();
				sr.sprite = deadheart;
				break;
			default: break;
		}
	}
}