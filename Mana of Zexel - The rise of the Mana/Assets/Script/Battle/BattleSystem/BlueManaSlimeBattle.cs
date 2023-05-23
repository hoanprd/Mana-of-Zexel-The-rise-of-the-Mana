using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueManaSlimeBattle : MonoBehaviour
{
    public Animator anibluemanaslime;
    public Transform Enemy;

    public int yes_BlueManaSlime = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_BlueManaSlime == 1)
        {
            //anibluemanaslime.SetTrigger("e9attack");
            Invoke("delayE9", 0.01f);
            yes_BlueManaSlime = 0;
        }
    }

    void delayE9()
    {
        if (BSBlueManaSlime1.E9Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y);
            anibluemanaslime.SetTrigger("e9attack");
            Invoke("delayE9Done", 1.7f);
        }
        else if (BSBlueManaSlime1.E9Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 7f, Enemy.position.y + 2);
            anibluemanaslime.SetTrigger("e9attack");
            Invoke("delayE9Done", 1.7f);
        }
        else if (BSBlueManaSlime1.E9Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 8f, Enemy.position.y - 2);
            anibluemanaslime.SetTrigger("e9attack");
            Invoke("delayE9Done", 1.7f);
        }
    }

    void delayE9Done()
    {
        Enemy.position = new Vector2(3.94f, -0.45f);
    }
}
