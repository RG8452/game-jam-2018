using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public int lives = 3;
    public Sprite cracked, broken;

	void Start()
	{
		
	}

	void Update()
	{
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Projectile"))
        { 
            lives--;
            Destroy(col.gameObject);
            GameObject.Find("Main Camera").GetComponent<CameraShake>().DoShake();

            if (lives == 2)
            {
                GameObject.Find("Body").GetComponent<SpriteRenderer>().sprite = cracked;
            }
            else if(lives == 1)
            {
                GameObject.Find("Body").GetComponent<SpriteRenderer>().sprite = broken;
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("EndingScene");
            }
        }
    }
}
