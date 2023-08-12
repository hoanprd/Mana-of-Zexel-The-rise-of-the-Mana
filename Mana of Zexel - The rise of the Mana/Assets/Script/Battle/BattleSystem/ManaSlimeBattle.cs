using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSlimeBattle : MonoBehaviour
{
    public Animator animanaslime;
    public Transform Enemy;

    public int yes_ManaSlime = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_ManaSlime == 1)
        {
            //animanaslime.SetTrigger("e5attack");
            Invoke("delayE5", 0.01f);
            yes_ManaSlime = 0;
        }
    }

    void delayE5()
    {
        if (BSManaSlime1.E5Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            animanaslime.SetTrigger("e5attack");
            Invoke("delayE5Done", 1.5f);
        }
        else if (BSManaSlime1.E5Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            animanaslime.SetTrigger("e5attack");
            Invoke("delayE5Done", 1.5f);
        }
        else if (BSManaSlime1.E5Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            animanaslime.SetTrigger("e5attack");
            Invoke("delayE5Done", 1.5f);
        }
    }

    void delayE5Done()
    {
        Enemy.position = new Vector2(3.87f, -0.33f);
    }
}
