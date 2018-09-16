using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject attackPrefab;
    public bool pmode;
    void Start()
	{
    }

	void Update()
	{
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.RightShift)&&pmode)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);

            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 180));
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightShift) && pmode)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 90));

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.RightShift) && pmode)
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 0));


        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightShift) && pmode)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 270));

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }




    }
}
