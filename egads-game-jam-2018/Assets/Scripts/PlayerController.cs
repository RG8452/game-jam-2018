using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject attackPrefab;
    public bool pmode;
    bool playerstatus = true;
    GameObject shield;
    Quaternion temp;
    void Start()
    {
        shield = GameObject.Find("Shield");
    }

    void Update()
    {



        if (Input.GetKeyDown(KeyCode.RightShift) && pmode)
        {
            if (playerstatus)
            {
                playerstatus = false;
                shield.SetActive(false);

            }
            else
            {
                playerstatus = true;
                
                shield.SetActive(true);
            }
        }



        if (Input.GetKeyDown(KeyCode.LeftArrow)&& !playerstatus)
        {
            temp = Quaternion.Euler(0, 0, 90);

            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 180));
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            temp = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && !playerstatus)
        {
            temp = Quaternion.Euler(0, 0, 0);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 90));

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            temp = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && !playerstatus)
        {
            temp = Quaternion.Euler(0, 0, 270);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 0));


        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            temp = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && !playerstatus)
        {
            temp = Quaternion.Euler(0, 0, 180);
            Instantiate(attackPrefab, this.transform.position, Quaternion.Euler(0, 0, 270));

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            temp = Quaternion.Euler(0, 0, 180);
        }

        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, temp, 10f * Time.deltaTime);


    }
}
