using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFangBattle : MonoBehaviour
{
    public Animator aniicefang;
    public Transform Enemy;

    public int yes_IceFang = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_IceFang == 1)
        {
            //aniicefang.SetTrigger("e8attack");
            Invoke("delayE8", 0.01f);
            yes_IceFang = 0;
        }
    }

    void delayE8()
    {
        if (BSIceFang1.E8Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            aniicefang.SetTrigger("e8attack");
            Invoke("delayE8Done", 1f);
        }
        else if (BSIceFang1.E8Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            aniicefang.SetTrigger("e8attack");
            Invoke("delayE8Done", 1f);
        }
        else if (BSIceFang1.E8Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            aniicefang.SetTrigger("e8attack");
            Invoke("delayE8Done", 1f);
        }
    }

    void delayE8Done()
    {
        Enemy.position = new Vector2(4.03f, -0.58f);
    }
}
