using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostChasing : MonoBehaviour
{
    public Animator GhostRotate;
    public GameObject Player, Enemy;
    public bool IsInRange, OutOfRange;
    public float speed;
    Vector2 OldPosition;

    // Start is called before the first frame update
    void Start()
    {
        OldPosition.x = Enemy.transform.position.x;
        OldPosition.y = Enemy.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInRange == true && OutOfRange == false)
        {
            if (Enemy.transform.position.x > Player.transform.position.x)
            {
                //GhostRotate.SetTrigger("e10left");
                GhostRotate.SetBool("e11left", true);
                GhostRotate.SetBool("e11right", false);
            }
            else if (Enemy.transform.position.x < Player.transform.position.x)
            {
                //GhostRotate.SetTrigger("e10right");
                GhostRotate.SetBool("e11left", false);
                GhostRotate.SetBool("e11right", true);
            }

            Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, Player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            if (Enemy.transform.position.x > Player.transform.position.x)
            {
                //GhostRotate.SetTrigger("e10right");
                GhostRotate.SetBool("e11left", false);
                GhostRotate.SetBool("e11right", true);
            }
            else if (Enemy.transform.position.x < Player.transform.position.x)
            {
                //GhostRotate.SetTrigger("e10left");
                GhostRotate.SetBool("e11left", true);
                GhostRotate.SetBool("e11right", false);
            }

            Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, OldPosition, speed * Time.deltaTime);
        }

        if (Enemy.transform.position.x == OldPosition.x && Enemy.transform.position.y == OldPosition.y)
        {
            OutOfRange = false;
        }
        if (Enemy.transform.position.x - OldPosition.x >= 10 || Enemy.transform.position.x - OldPosition.x <= -10 || Enemy.transform.position.x - OldPosition.x >= 10 || Enemy.transform.position.y - OldPosition.y <= -10)
        {
            OutOfRange = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsInRange = false;
        }
    }
}
