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
	}

    void OnCollisionEnter(Collision col)
    {
        lives++;
        Destroy(col.gameObject);
        GameObject.Find("Main Camera").GetComponent<CameraShake>().DoShake();

		if(lives <= 0)
		{
            //Destroy(gameObject);
            SceneManager.LoadScene("EndingScene");
		}
    }
}
