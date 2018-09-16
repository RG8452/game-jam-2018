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
<<<<<<< HEAD
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
=======
        Debug.Log(pManagerScript.lives);
        if(pManagerScript.lives==2)
        {
            GameObject temp = GameObject.Find("Life Point 3");
            
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
            GameObject temp = GameObject.Find("Life Point 1");
            Image sr = temp.GetComponent<Image>();
            sr.sprite = deadheart;
        }
        GameObject temp2 = GameObject.Find("Score");
        temp2.GetComponent<Text>().text = "Time: "+Time.time.ToString("0.00"); ;
    }
}
>>>>>>> 8b0ed082ae4235289a0c06e03b2ab1d4c0786652
