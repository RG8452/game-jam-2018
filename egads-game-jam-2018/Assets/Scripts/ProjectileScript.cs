using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
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
<<<<<<< HEAD
        moveSpeed = portalScript.GetBaseSpeed();
        portalIndex = Random.Range(0, portalScript.portals.Length - 1);
=======
        moveSpeed = portalScript.getBaseSpeed();
        portalIndex = Random.Range(0, portalScript.portals.Length );
>>>>>>> d2257b9fbc9ca2daa8e897c90454ca2f7fb75bdc
        gameObject.transform.position = portalScript.portals[portalIndex].transform.position;
	}

	void Update()
	{
		float move = moveSpeed * Time.deltaTime;
        switch(portalIndex)
        {
            case 0:
                transform.Translate(new Vector3(0, -move, 0));
                transform.rotate(Quaternion.Euler(0, 0, 270));
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
