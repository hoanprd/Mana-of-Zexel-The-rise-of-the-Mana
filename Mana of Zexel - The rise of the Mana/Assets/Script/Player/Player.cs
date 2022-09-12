using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float move_speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Text show1;
    public GameObject show2;
    public Text show3;
    public GameObject show4;
    private bool heal, tqz, mqz;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        if (heal && Input.GetKeyDown(KeyCode.Space))
        {
            if (Global.Zen >= 100)
            {
                show2.SetActive(true);
                show1.text = "-100 Zen";
                Global.Zen -= 100;
                Global.CurHPP1 = Global.MaxHPP1;
                Global.CurMPP1 = Global.MaxMPP1;
                Global.CurHPP2 = Global.MaxHPP2;
                Global.CurMPP2 = Global.MaxMPP2;
                Invoke("delay1", 2f);
            }
            else
            {
                show2.SetActive(true);
                show1.text = "Not enough Zen!";
                Invoke("delay1", 2f);
            }
        }
        if (tqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus4 == 1 && CutscenesController.cus6 == 0)
            {
                if (ContainerController.HealPotion > 0)
                {
                    ContainerController.HealPotion -= 1;
                    SceneManager.LoadScene(7);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "Not enough heal potion!";
                    Invoke("delay1", 2f);
                }
            }
            else if (CutscenesController.cus6 == 1 && CutscenesController.cus7 == 0)
            {
                if (GlobalQuest.KillGoblinQuest == 4)
                {
                    SceneManager.LoadScene(7);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You need to defeat at least 4 goblins";
                    Invoke("delay1", 2f);
                }
            }
        }
        if (mqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus11 == 0)
            {
                SceneManager.LoadScene(7);
            }
            else if (CutscenesController.cus11 == 1)
            {
                if (ContainerController.ManaGem >= 3)
                {
                    ContainerController.ManaGem -= 3;
                    SceneManager.LoadScene(7);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You don't have enough 3 mana gem!";
                    Invoke("delay1", 2f);
                }
            }
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastY", Input.GetAxisRaw("Vertical"));
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CS1"))
        {
            PlayerPrefs.SetInt("CPosi1", 1);
            if (CutscenesController.cus3 == 0)
                SceneManager.LoadScene(7);
            else
                SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("BS1"))
        {
            PlayerPrefs.SetInt("BPosi1", 1);
            SceneManager.LoadScene(2);
        }
        if (collision.CompareTag("CS2"))
        {
            PlayerPrefs.SetInt("CPosi2", 1);
            if (CutscenesController.cus4 == 0)
                SceneManager.LoadScene(7);
            else
                SceneManager.LoadScene(5);
        }
        if (collision.CompareTag("BS2"))
        {
            PlayerPrefs.SetInt("BPosi2", 1);
            if (CutscenesController.cus7 == 1 && CutscenesController.cus8 == 0)
                SceneManager.LoadScene(7);
            else
                SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("CS3"))
        {
            PlayerPrefs.SetInt("CPosi3", 1);
            if (CutscenesController.cus5 == 0)
                SceneManager.LoadScene(7);
            else
                SceneManager.LoadScene(6);
        }
        if (collision.CompareTag("BS3"))
        {
            PlayerPrefs.SetInt("BPosi3", 1);
            SceneManager.LoadScene(5);
        }
        if (collision.CompareTag("CS4"))
        {
            if (CutscenesController.cus9 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else
            {
                if (CutscenesController.cus10 == 0)
                {
                    PlayerPrefs.SetInt("CPosi4", 1);
                    SceneManager.LoadScene(7);
                }
                else
                {
                    PlayerPrefs.SetInt("CPosi4", 1);
                    SceneManager.LoadScene(4);
                }
            }
        }
        if (collision.CompareTag("BS4"))
        {
            PlayerPrefs.SetInt("BPosi4", 1);
            SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("HealPoint"))
        {
            heal = true;
        }
        if (collision.CompareTag("TQZ"))
        {
            tqz = true;
        }
        if (collision.CompareTag("MQZ"))
        {
            mqz = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HealPoint"))
        {
            heal = false;
        }
        if (collision.CompareTag("TQZ"))
        {
            tqz = false;
        }
        if (collision.CompareTag("MQZ"))
        {
            mqz = false;
        }
    }
    void delay1()
    {
        show2.SetActive(false);
    }
    void delay2()
    {
        show4.SetActive(false);
    }
}
