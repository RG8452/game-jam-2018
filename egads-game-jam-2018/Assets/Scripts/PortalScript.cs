using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
	public GameObject[] portals;
	public GameObject projectilePrefab;
    public GameObject fastProjectilePrefab;
    public GameObject slowProjectilePrefab;
    private const float BASE_PROJECTILE_SPEED = 1.25f;
    private float lastFireTime;
//  private float timeToFire = 2f;
    private float spawnRate = 1.33f;
    private float projectileSpeed = BASE_PROJECTILE_SPEED;
	GameObject projectile;
    ShieldScript shieldScript;
    int temp = 0;


	void Start()
	{
        portals = new GameObject[] {GameObject.Find("Portal"), GameObject.Find("Portal (1)"),
                                    GameObject.Find("Portal (2)"), GameObject.Find("Portal (3)") };
        shieldScript = GameObject.Find("Shield").GetComponent<ShieldScript>();
        lastFireTime = Time.time;
    }

	void Update()
	{
        if(Time.time - lastFireTime > spawnRate)
        {
            shootProjectile();
            lastFireTime = Time.time;
        }
    }

    public void shootProjectile()
    {
        int rngesus = Random.Range(0, 100);
        if (rngesus <= 66)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        else if (rngesus <= 80)
        {
            Instantiate(slowProjectilePrefab);
        }
        else
        {
            Instantiate(fastProjectilePrefab);
        }
        if (shieldScript.getBlockCount() < 100)
        {
            projectileSpeed += .01f;
            if(shieldScript.getBlockCount() % 4 == 0)
            {
                spawnRate -= .035f;
            }
        }
        else
        {
            if(shieldScript.getBlockCount() % 6 == 0)
            {
                spawnRate -= .01f;
                if(spawnRate < .1)
                {
                    spawnRate = .1f;
                }
                projectileSpeed += .008f;
            }
        }
    }

    public float GetBaseSpeed()
    {
        return projectileSpeed;
    }
}
