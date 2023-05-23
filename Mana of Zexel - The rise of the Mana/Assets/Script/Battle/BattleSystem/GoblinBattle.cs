using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBattle : MonoBehaviour
{
    public Animator anigoblin;
    public Transform Enemy;

    public int yes_goblin = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_goblin == 1)
        {
            //anigoblin.SetTrigger("e2attack");
            Invoke("delayE2", 0.01f);
            yes_goblin = 0;
        }
    }

    void delayE2()
    {
        if (BSGoblin1.E2Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            anigoblin.SetTrigger("e2attack");
            Invoke("delayE2Done", 1f);
        }
        else if (BSGoblin1.E2Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            anigoblin.SetTrigger("e2attack");
            Invoke("delayE2Done", 1f);
        }
        else if (BSGoblin1.E2Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            anigoblin.SetTrigger("e2attack");
            Invoke("delayE2Done", 1f);
        }
    }

    void delayE2Done()
    {
        Enemy.position = new Vector2(4.24f, -0.21f);
    }
}
