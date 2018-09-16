using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastProjectileScript : MonoBehaviour
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
        moveSpeed = portalScript.GetBaseSpeed() * 2;
        portalIndex = Random.Range(0, portalScript.portals.Length - 1);
        gameObject.transform.position = portalScript.portals[portalIndex].transform.position;
    }

    void Update()
    {
        float move = moveSpeed * Time.deltaTime;
        switch(portalIndex)
        {
            case 0:
                transform.rotation = (Quaternion.Euler(0, 0, 270));
                transform.Translate(new Vector3(move, 0, 0));

                break;
            case 1:
                transform.rotation = (Quaternion.Euler(0, 0, 180));
                transform.Translate(new Vector3(move, 0, 0));

                break;
            case 2:

                transform.rotation = (Quaternion.Euler(0, 0, 90));
                transform.Translate(new Vector3(move, 0, 0));
                break;
            case 3:
                transform.rotation = (Quaternion.Euler(0, 0, 0));
                transform.Translate(new Vector3(move, 0, 0));

                break;
        }
    }
}