using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattle : MonoBehaviour
{
    public Animator ani;
    public Animator anip2;
    public Animator anip3;
    public Transform P1;
    public Transform P2;
    public int yes1=0;
    public int yes2=0;
    public int yes3=0;
    public int yes4=0;
    public int yes5=0;
    public int yes6=0;

    public int yes7 = 0, yes8 = 0, p1YesGetHit;
    public int yes9 = 0, yes10 = 0, p2YesGetHit;
    public int yes11 = 0, yes12 = 0, p3YesGetHit;
    public int dead1=0;
    public int dead2=0;
    public int dead3=0;
    public float MoveSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        //ani = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CutscenesController.cus2 == 0)
        {
            if (yes1 == 1)
            {
                ani.SetTrigger("p1attack");
                yes1 = 0;
            }
            if (yes2 == 1)
            {
                P1.position = new Vector2(P1.position.x + 5f, P1.position.y);
                ani.SetTrigger("p1skill");
                Invoke("delayP1", 1.2f);
                yes2 = 0;
            }
            if (yes7 == 1)
            {
                ani.SetTrigger("p1skill2");
                yes7 = 0;
            }
            if (yes8 == 1)
            {
                ani.SetTrigger("p1skill3");
                yes8 = 0;
            }
            if (p1YesGetHit == 1)
            {
                ani.SetTrigger("p1gethit");
                p1YesGetHit = 0;
            }

            if (dead1 == 1)
            {
                ani.SetBool("p1dead", true);
            }
            else
            {
                ani.SetBool("p1dead", false);
            }
        }
        else
        {
            if (yes1 == 1)
            {
                ani.SetTrigger("p1attack");
                yes1 = 0;
            }
            if (yes2 == 1)
            {
                P1.position = new Vector2(P1.position.x + 5f, P1.position.y);
                ani.SetTrigger("p1skill");
                Invoke("delayP1", 1.2f);
                yes2 = 0;
            }
            if (yes7 == 1)
            {
                ani.SetTrigger("p1skill2");
                yes7 = 0;
            }
            if (yes8 == 1)
            {
                ani.SetTrigger("p1skill3");
                yes8 = 0;
            }
            if (p1YesGetHit == 1)
            {
                ani.SetTrigger("p1gethit");
                p1YesGetHit = 0;
            }

            if (yes3 == 1)
            {
                P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
                anip2.SetTrigger("p2attack");
                Invoke("delayP2", 1.5f);
                yes3 = 0;
            }
            if (yes4 == 1)
            {
                P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
                anip2.SetTrigger("p2skill");
                Invoke("delayP2", 2f);
                yes4 = 0;
            }
            if (yes9 == 1)
            {
                P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
                anip2.SetTrigger("p2skill2");
                Invoke("delayP2", 2f);
                yes9 = 0;
            }
            if (yes10 == 1)
            {
                P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
                anip2.SetTrigger("p2skill3");
                Invoke("delayP2", 2.2f);
                yes10 = 0;
            }
            if (p2YesGetHit == 1)
            {
                anip2.SetTrigger("p2gethit");
                p2YesGetHit = 0;
            }


            if (yes5 == 1)
            {
                anip3.SetTrigger("p3attack");
                yes5 = 0;
            }
            if (yes6 == 1)
            {
                anip3.SetTrigger("p3skill");
                yes6 = 0;
            }
            if (yes11 == 1)
            {
                anip3.SetTrigger("p3skill2");
                yes11 = 0;
            }
            if (yes12 == 1)
            {
                anip3.SetTrigger("p3skill3");
                yes12 = 0;
            }
            if (p3YesGetHit == 1)
            {
                anip3.SetTrigger("p3gethit");
                p3YesGetHit = 0;
            }


            if (dead1 == 1)
            {
                ani.SetBool("p1dead", true);
            }
            else
            {
                ani.SetBool("p1dead", false);
            }
            if (dead2 == 1)
            {
                anip2.SetBool("p2dead", true);
            }
            else
            {
                anip2.SetBool("p2dead", false);
            }
            if (dead3 == 1)
            {
                anip3.SetBool("p3dead", true);
            }
            else
            {
                anip3.SetBool("p3dead", false);
            }
        }

        /*if (yes1 == 1)
        {
            ani.SetTrigger("p1attack");
            yes1 = 0;
        }
        if(yes2 == 1)
        {
            P1.position = new Vector2(P1.position.x + 5f, P1.position.y);
            ani.SetTrigger("p1skill");
            Invoke("delayP1", 1.2f);
            yes2 = 0;
        }
        if (yes7 == 1)
        {
            ani.SetTrigger("p1skill2");
            yes7 = 0;
        }
        if (yes8 == 1)
        {
            ani.SetTrigger("p1skill3");
            yes8 = 0;
        }
        if (p1YesGetHit == 1)
        {
            ani.SetTrigger("p1gethit");
            p1YesGetHit = 0;
        }

        if (yes3 == 1)
        {
            P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
            anip2.SetTrigger("p2attack");
            Invoke("delayP2", 1f);
            yes3 = 0;
        }
        if(yes4 == 1)
        {
            P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
            anip2.SetTrigger("p2skill");
            Invoke("delayP2", 2f);
            yes4 = 0;
        }
        if (yes9 == 1)
        {
            P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
            anip2.SetTrigger("p2skill2");
            Invoke("delayP2", 2f);
            yes9 = 0;
        }
        if (yes10 == 1)
        {
            P2.position = new Vector2(P2.position.x + 8f, P2.position.y - 1.5f);
            anip2.SetTrigger("p2skill3");
            Invoke("delayP2", 2.2f);
            yes10 = 0;
        }
        if (p2YesGetHit == 1)
        {
            anip2.SetTrigger("p2gethit");
            p2YesGetHit = 0;
        }


        if (yes5 == 1)
        {
            anip3.SetTrigger("p3attack");
            yes5 = 0;
        }
        if (yes6 == 1)
        {
            anip3.SetTrigger("p3skill");
            yes6 = 0;
        }
        if (yes11 == 1)
        {
            anip3.SetTrigger("p3skill2");
            yes11 = 0;
        }
        if (yes12 == 1)
        {
            anip3.SetTrigger("p3skill3");
            yes12 = 0;
        }
        if (p3YesGetHit == 1)
        {
            anip3.SetTrigger("p3gethit");
            p3YesGetHit = 0;
        }


        if (dead1 == 1)
        {
            ani.SetBool("p1dead", true);
        }
        else
        {
            ani.SetBool("p1dead", false);
        }
        if(dead2 == 1)
        {
            anip2.SetBool("p2dead", true);
        }
        else
        {
            anip2.SetBool("p2dead", false);
        }
        if (dead3 == 1)
        {
            anip3.SetBool("p3dead", true);
        }
        else
        {
            anip3.SetBool("p3dead", false);
        }*/
    }

    void delayP1()
    {
        P1.position = new Vector2(P1.position.x - 5f, P1.position.y);
    }

    void delayP2()
    {
        P2.position = new Vector2(P2.position.x - 8f, P2.position.y + 1.5f);
    }
}
