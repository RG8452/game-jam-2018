using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
	public GameObject[] portals;
	public GameObject projectilePrefab;
    public GameObject fastProjectilePrefab;
    public GameObject slowProjectilePrefab;
    private const float BASE_PROJECTILE_SPEED = 1.5f;
    private float lastFireTime;
    private float timeToFire = 2f;
    private float spawnRate = 2.00f;
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
        InvokeRepeating("ShootProjectile", 0, spawnRate);
    }

	void Update()
	{
        if(Time.time - lastFireTime > timeToFire)
        {
        }
        timeToFire = (float)(2 - .05 * ((int)(shieldScript.getBlockCount() / 5)));
        projectileSpeed = (float)(1 + (shieldScript.getBlockCount() / 75.0));
        
        //timeToFire = (float)(2 - .1 * ((int)(shieldScript.getBlockCount() / 5)));
        //Debug.Log(timeToFire);
        //projectileSpeed = (float)(1 + (shieldScript.getBlockCount() / 75.0));
        //Debug.Log(projectileSpeed);
    }
    public void ShootProjectile()
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
        if (shieldScript.getBlockCount() % 75 == 0 && temp != shieldScript.getBlockCount()) 
        {
            projectileSpeed += 1;
        }
        if (shieldScript.getBlockCount() % 5 == 0 && temp != shieldScript.getBlockCount()) 
        {
            Debug.Log(shieldScript.getBlockCount() + "  " + temp + "  " + spawnRate);
            spawnRate *=0.95f;
            if(spawnRate<0.5)
            {
                spawnRate = 0.5f;
            }
            temp = shieldScript.getBlockCount();
            Repeater();
        }
    }
    public void Repeater()
    {
       
        CancelInvoke("ShootProjectile");
        InvokeRepeating("ShootProjectile", 0, spawnRate);
    }
    public float GetBaseSpeed()
    {
        return projectileSpeed;
    }
}
