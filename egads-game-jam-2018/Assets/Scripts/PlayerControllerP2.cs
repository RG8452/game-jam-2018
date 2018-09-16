﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP2 : MonoBehaviour
{
    public GameObject attackPrefab;
    public bool pmode;
    bool playerstatus=true;
    GameObject shield;
    void Start()
    {
        shield = GameObject.Find("ShieldP2");
    }

    void Update()
    {



        if(Input.GetKeyDown(KeyCode.LeftShift)&&pmode)
        {
            if (playerstatus)
            {
                playerstatus = false;
                shield.SetActive(false);

            }
            else
            {
                playerstatus = true;
                shield.SetActive(true);

                
            }
        }



        if (Input.GetKeyDown(KeyCode.A) && !playerstatus)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 180));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.W) && !playerstatus)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 90));

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && !playerstatus)
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 270);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 0));

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.S) && !playerstatus)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 270));

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }




    }
}
