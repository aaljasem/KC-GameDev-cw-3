using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class da : MonoBehaviour
{
    // Start is called before the first frame update
    string heroname = "Jasem";
    int heropower = 12;
    string villainName = "Ahmad";
    int villainPower = 20;
    float playerSpeed = 5.5f;
    float playerSpeed2 = 0f;



    void Start()
    {
       


        if (heropower > villainPower)
        {
            print("jasem is stronger");


        }
        else
        {
            print("Ahmad is stronger");
        }

        SetSpeed(2.5f);

        if (playerSpeed> playerSpeed2)
        {
            print("he became faster");


        }
        else
        {
            print("he is slower");
        }

    }

    void SetSpeed(float speed)
    {
        playerSpeed2 = speed;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
