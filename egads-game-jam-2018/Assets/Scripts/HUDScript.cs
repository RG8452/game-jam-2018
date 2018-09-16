﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement
public class HUDScript : MonoBehaviour
{
	PlayerManager pManagerScript;
    PlayerManager pManagerScriptP2;
    public Sprite deadheart;
	public GameObject[] lives;
	public Image gameBG;
	float timeLeft;
	Color targetColor;
    public bool player;
	void Start()
	{
		pManagerScript = GameObject.Find("Player").GetComponent<PlayerManager>();
        if(player)
            pManagerScriptP2 = GameObject.Find("PlayerP2").GetComponent<PlayerManager>();
    }

	void Update()
	{
//      pManagerScript.lives++;
        //Debug.Log(pManagerScript.lives);
        if (pManagerScript.lives==2)
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
        //pManagerScriptP2.lives++;
        if (player)
        {
            if (pManagerScriptP2.lives == 2)
            {
                GameObject temp2 = GameObject.Find("Life Point 3P2");

                Image sr2 = temp2.GetComponent<Image>();
                sr2.sprite = deadheart;
            }
            else if (pManagerScriptP2.lives == 1)
            {
                GameObject temp2 = GameObject.Find("Life Point 2P2");
                Image sr2 = temp2.GetComponent<Image>();
                sr2.sprite = deadheart;
            }
            else if (pManagerScriptP2.lives == 0)
            {
               // SceneManager.LoadScene("EndingScene");
                GameObject temp2 = GameObject.Find("Life Point 1P2");
                Image sr2 = temp2.GetComponent<Image>();
                sr2.sprite = deadheart;
            }
        }

		ChangeBGColor(gameBG);
    }

	void ChangeBGColor(Image bg)
	{
		if(timeLeft <= Time.deltaTime)
		{
			// transition complete
			// assign the target color
			gameBG.color = targetColor;

			// start a new transition
			targetColor = new Color(Random.value, Random.value, Random.value);
			timeLeft = 5f;
		}
		else
		{
			// transition in progress
			// calculate interpolated color
			gameBG.color = Color.Lerp(gameBG.color, targetColor, Time.deltaTime / timeLeft);

			// update the timer
			timeLeft -= Time.deltaTime;
		}
	}
}
