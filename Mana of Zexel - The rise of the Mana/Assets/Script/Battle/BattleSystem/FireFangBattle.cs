using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFangBattle : MonoBehaviour
{
    public Animator anifirefang;
    public Transform Enemy;

    public int yes_FireFang = 0;


    // Update is called once per frame
    void Update()
    {
        if (yes_FireFang == 1)
        {
            //anifirefang.SetTrigger("e7attack");
            Invoke("delayE6", 0.01f);
            yes_FireFang = 0;
        }
    }

    void delayE6()
    {
        if (BSFireFang1.E6Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y);
            anifirefang.SetTrigger("e6attack");
            Invoke("delayE6Done", 1f);
        }
        else if (BSFireFang1.E6Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 7f, Enemy.position.y + 2);
            anifirefang.SetTrigger("e6attack");
            Invoke("delayE6Done", 1f);
        }
        else if (BSFireFang1.E6Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 8f, Enemy.position.y - 2);
            anifirefang.SetTrigger("e6attack");
            Invoke("delayE6Done", 1f);
        }
    }

    void delayE6Done()
    {
        Enemy.position = new Vector2(4.01f, -0.56f);
    }
}
