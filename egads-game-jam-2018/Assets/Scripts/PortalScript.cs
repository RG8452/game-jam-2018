using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
	public GameObject[] portals;
	public GameObject projectilePrefab;
    public GameObject fastProjectilePrefab;
    public GameObject slowProjectilePrefab;
    private const float BASE_PROJECTILE_SPEED = 1f;
    private float lastFireTime;
    private float timeToFire = 2f;
    private float projectileSpeed = BASE_PROJECTILE_SPEED;
	GameObject projectile;
    ShieldScript shieldScript;

	void Start()
	{
        portals = new GameObject[] {GameObject.Find("Portal"), GameObject.Find("Portal (1)"),
                                    GameObject.Find("Portal (2)"), GameObject.Find("Portal (3)") };
        shieldScript = GameObject.Find("Shield").GetComponent<ShieldScript>();
		projectile = Instantiate(slowProjectilePrefab);
        lastFireTime = Time.time;
	}

	void Update()
	{
        if(Time.time - lastFireTime > timeToFire)
        {
            int rngesus = Random.Range(0, 100);
            if (rngesus <= 66) {
                Instantiate(projectilePrefab);
            } else if (rngesus <= 80) {
                Instantiate(slowProjectilePrefab);
            } else {
                Instantiate(fastProjectilePrefab);
            }
            lastFireTime = Time.time;
        }
        timeToFire = (float)(2 - .05 * ((int)(shieldScript.getBlockCount() / 5)));
        projectileSpeed = (float)(1 + (shieldScript.getBlockCount() / 75.0));
	}

    public float getBaseSpeed()
    {
        return projectileSpeed;
    }
}
