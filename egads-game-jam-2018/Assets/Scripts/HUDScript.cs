﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
	PlayerManager pManagerScript;
    PlayerManager pManagerScriptP2;
    public Sprite deadheart;
	public GameObject[] lives;
    public bool player;
	void Start()
	{
		pManagerScript = GameObject.Find("Player").GetComponent<PlayerManager>();
        if(player)
            pManagerScriptP2 = GameObject.Find("PlayerP2").GetComponent<PlayerManager>();
    }

	void Update()
	{
        //Debug.Log(pManagerScript.lives);
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
        
        if(player)
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
                GameObject temp2 = GameObject.Find("Life Point 1P2");
                Image sr2 = temp2.GetComponent<Image>();
                sr2.sprite = deadheart;
            }
        //GameObject temp2 = GameObject.Find("Score");
        //temp2.GetComponent<Text>().text = "Time: "+Time.time.ToString("0.00"); ;
    }
}
