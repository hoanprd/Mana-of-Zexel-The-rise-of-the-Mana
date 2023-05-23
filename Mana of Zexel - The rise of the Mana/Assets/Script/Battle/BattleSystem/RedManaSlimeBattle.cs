using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedManaSlimeBattle : MonoBehaviour
{
    public Animator aniredmanaslime;
    public Transform Enemy;

    public int yes_RedManaSlime = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_RedManaSlime == 1)
        {
            //aniredmanaslime.SetTrigger("e7attack");
            Invoke("delayE7", 0.01f);
            yes_RedManaSlime = 0;
        }
    }

    void delayE7()
    {
        if (BSRedManaSlime1.E7Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            aniredmanaslime.SetTrigger("e7attack");
            Invoke("delayE7Done", 1f);
        }
        else if (BSRedManaSlime1.E7Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            aniredmanaslime.SetTrigger("e7attack");
            Invoke("delayE7Done", 1f);
        }
        else if (BSRedManaSlime1.E7Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            aniredmanaslime.SetTrigger("e7attack");
            Invoke("delayE7Done", 1f);
        }
    }

    void delayE7Done()
    {
        Enemy.position = new Vector2(3.87f, -0.33f);
    }
}
