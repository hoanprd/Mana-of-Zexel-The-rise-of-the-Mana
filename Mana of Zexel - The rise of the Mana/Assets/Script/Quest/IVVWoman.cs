using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IVVWoman : MonoBehaviour
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
                if (CutscenesController.cus114 == 0 && CutscenesController.cus111 == 1)
                {
                    CutscenesController.cus114FIndex = 1;
                    SceneManager.LoadScene("Cutscenes");
                }

                if (CutscenesController.cus115 == 0 && CutscenesController.cus114 == 1 && ContainerController.FireOre >= 10 && ContainerController.RedManaCrystal >= 10)
                {
                    CutscenesController.cus115FIndex = 1;
                    SceneManager.LoadScene("Cutscenes");
                }
                else if (CutscenesController.cus115 == 0 && CutscenesController.cus114 == 1 && ContainerController.FireOre < 10 && ContainerController.RedManaCrystal < 10)
                {
                    once = 1;
                    show2.SetActive(true);
                    show1.text = "You need at least 10 fire ore and 10 red mana crystal";
                    Invoke("delay1", 2f);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsReady = true;

            if (once == 0 && CutscenesController.cus111 == 1 && CutscenesController.cus114 == 0)
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
            else if (once == 0 && CutscenesController.cus114 == 1 && CutscenesController.cus115 == 0)
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

    void delay1()
    {
        once = 0;
        show2.SetActive(false);
        show1.text = "";
    }
}
