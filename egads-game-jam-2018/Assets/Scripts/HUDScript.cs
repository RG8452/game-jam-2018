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
        if(pManagerScript.lives==2)
        {
            temp = GameObject.Find("Life Point 3");
            
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        else if (pManagerScript.lives == 1)
        {
            temp = GameObject.Find("Life Point 2");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        else if (pManagerScript.lives == 0)
        {
            temp = GameObject.Find("Life Point 1");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        GameObject temp2 = GameObject.Find("Score");
        temp2.GetComponent<Text>().text = "Time: "+Time.time.ToString("0.00"); ;
    }
}