using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public int lives = 3;
    public Sprite cracked, broken;
    GameObject body;
    public bool pmode;
	void Start()
	{
		if(pmode)
        {
            body = GameObject.Find("BodyP2");
        }
        else
        {
            body = GameObject.Find("Body");
        }
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
                body.GetComponent<SpriteRenderer>().sprite = cracked;
            }
            else if(lives == 1)
            {
               body.GetComponent<SpriteRenderer>().sprite = broken;
            }
            if (lives <= 0)
            {
//                Destroy(gameObject);
                SceneManager.LoadScene("EndingScene");
            }
        }
    }
}
