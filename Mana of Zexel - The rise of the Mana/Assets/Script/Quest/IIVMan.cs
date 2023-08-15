using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IIVMan : MonoBehaviour
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
                if (CutscenesController.cus116 == 0 && CutscenesController.cus111 == 1)
                {
                    SceneManager.LoadScene("Cutscenes");
                }

                if (CutscenesController.cus117 == 0 && CutscenesController.cus116 == 1 && CutscenesTrigger.IceFangKill2 >= 8)
                {
                    SceneManager.LoadScene("Cutscenes");
                }
                else if (CutscenesController.cus117 == 0 && CutscenesController.cus116 == 1 && CutscenesTrigger.IceFangKill2 < 8)
                {
                    once = 1;
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

            if (once == 0 && CutscenesController.cus111 == 1 && CutscenesController.cus116 == 0)
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
            else if (once == 0 && CutscenesController.cus116 == 1 && CutscenesController.cus117 == 0)
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
        show2.SetActive(true);
        show1.text = "You need to beat " + CutscenesTrigger.IceFangKill2 + "/8 ice fang";
    }
}
