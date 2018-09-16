using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
	PlayerManager pManagerScript;
    public Sprite deadheart;
	public GameObject[] lives;

	void Start()
	{
		pManagerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
	}

	void Update()
	{
        Debug.Log(pManagerScript.lives);
        if(pManagerScript.lives==2)
        {
            GameObject temp = GameObject.Find("Life Point 1");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        else if (pManagerScript.lives == 1)
        {
            GameObject temp = GameObject.Find("Life Point 2");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        else if (pManagerScript.lives == 0)
        {
            GameObject temp = GameObject.Find("Life Point 3");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }

    }
}
