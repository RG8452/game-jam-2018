using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public int lives = 3;


	void Start()
	{
		
	}

	void Update()
	{
		print("Lives: " + lives);
	}

    void OnCollisionEnter(Collision col)
    {
        lives--;
		print(col.gameObject.name);
        Destroy(col.gameObject);

		if(lives <= 0)
		{
            //Destroy(gameObject);
            SceneManager.LoadScene("EndingScene");
		}
    }
}
