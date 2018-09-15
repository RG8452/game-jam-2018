﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowProjectileScript : MonoBehaviour
{
    public float moveSpeed;
    private int portalIndex;
    public PortalScript portalScript;

    void Awake()
    {
        portalScript = GameObject.Find("Portals").GetComponent<PortalScript>();
    }

    void Start()
    {
        moveSpeed = portalScript.getBaseSpeed() / 2;
        portalIndex = Random.Range(0, portalScript.portals.Length - 1);
        gameObject.transform.position = portalScript.portals[portalIndex].transform.position;
    }

    void Update()
    {
        float move = moveSpeed * Time.deltaTime;
        switch (portalIndex)
        {
            case 0:
                transform.Translate(new Vector3(0, -move, 0));
                break;
            case 1:
                transform.Translate(new Vector3(-move, 0, 0));
                break;
            case 2:
                transform.Translate(new Vector3(0, move, 0));
                break;
            case 3:
                transform.Translate(new Vector3(move, 0, 0));
                break;
        }
    }
}