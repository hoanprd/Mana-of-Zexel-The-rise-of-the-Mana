using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBattle : MonoBehaviour
{
    public Animator anighost;
    public Transform Enemy;

    public int yes_Ghost = 0;

    // Update is called once per frame
    void Update()
    {
        if (yes_Ghost == 1)
        {
            //anighost.SetTrigger("e11attack");
            Invoke("delayE11", 0.01f);
            yes_Ghost = 0;
        }
    }

    void delayE11()
    {
        if (BSGhost1.E11Hit == 1)
        {
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            anighost.SetTrigger("e11attack");
            Invoke("delayE11Done", 1f);
        }
        else if (BSGhost1.E11Hit == 2)
        {
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            anighost.SetTrigger("e11attack");
            Invoke("delayE11Done", 1f);
        }
        else if (BSGhost1.E11Hit == 3)
        {
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            anighost.SetTrigger("e11attack");
            Invoke("delayE11Done", 1f);
        }
    }

    void delayE11Done()
    {
        Enemy.position = new Vector2(2.14f, 0.61f);
    }
}
