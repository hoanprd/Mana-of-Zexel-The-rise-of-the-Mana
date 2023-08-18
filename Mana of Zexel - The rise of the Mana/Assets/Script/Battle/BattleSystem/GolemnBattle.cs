using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemnBattle : MonoBehaviour
{
    public Animator anigolemn;
    public Transform Enemy;
    public Canvas _canvas;

    public int yes_golemn = 0;

    // Start is called before the first frame update
    void Start()
    {
        //anithief = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yes_golemn == 1)
        {
            Invoke("delayE3", 0.01f);
            yes_golemn = 0;
        }
    }

    void delayE3()
    {
        if (BSGolemn1.E3Hit == 1)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 3f, Enemy.position.y);
            anigolemn.SetTrigger("e3attack");
            Invoke("delayE3Done", 1.5f);
        }
        else if (BSGolemn1.E3Hit == 2)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 5f, Enemy.position.y + 1);
            anigolemn.SetTrigger("e3attack");
            Invoke("delayE3Done", 1.5f);
        }
        else if (BSGolemn1.E3Hit == 3)
        {
            _canvas.sortingOrder = 1;
            Enemy.position = new Vector2(Enemy.position.x - 6f, Enemy.position.y - 3);
            anigolemn.SetTrigger("e3attack");
            Invoke("delayE3Done", 1.5f);
        }
    }

    void delayE3Done()
    {
        Enemy.position = new Vector2(4.06f, 0.64f);
        _canvas.sortingOrder = 3;
    }
}
