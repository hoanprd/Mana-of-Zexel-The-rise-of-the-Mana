using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IIVWoman : MonoBehaviour
{
    public int once;
    public bool IsReady;

    public Text show1;
    public GameObject show2;

    // Start is called before the first frame update
    void Start()
    {
        once = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsReady)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (CutscenesController.cus118 == 0 && CutscenesController.cus111 == 1)
                {
                    SceneManager.LoadScene("Cutscenes");
                }

                if (CutscenesController.cus121 == 0 && CutscenesController.cus120 == 1)
                {
                    SceneManager.LoadScene("Cutscenes");
                }
                /*else if (CutscenesController.cus118 == 1 && CutscenesController.cus121 == 0)
                {
                    once = 1;
                    Invoke("delay1", 2f);
                }*/
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsReady = true;

            if (once == 0 && CutscenesController.cus111 == 1 && CutscenesController.cus118 == 0)
            {
                if (once == 0)
                {
                    show2.SetActive(true);
                    show1.text = "Press Space to talk with the villager";
                }
                else
                {
                    show2.SetActive(false);
                }
            }
            else if (once == 0 && CutscenesController.cus120 == 1 && CutscenesController.cus121 == 0)
            {
                if (once == 0)
                {
                    show2.SetActive(true);
                    show1.text = "Press Space to commit the quest";
                }
                else
                {
                    show2.SetActive(false);
                }
            }
            else if (once == 0 && CutscenesController.cus128 == 1 && CutscenesController.cus120 == 0)
            {
                if (once == 0)
                {
                    show2.SetActive(true);
                    show1.text = "Please help find my husband, the last time he was lost was in the ice cave";
                }
                else
                {
                    show2.SetActive(false);
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsReady = false;
            show2.SetActive(false);
        }
    }

    /*void delay1()
    {
        once = 0;
        
    }*/
}
