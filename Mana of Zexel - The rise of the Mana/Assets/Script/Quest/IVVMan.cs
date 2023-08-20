using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IVVMan : MonoBehaviour
{
    public int once;
    public bool IsReady;

    public Text show1;
    public GameObject show2, FadeInPanel;

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
                if (CutscenesController.cus112 == 0 && CutscenesController.cus111 == 1)
                {
                    CutscenesController.cus112FIndex = 1;
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
                }

                if (CutscenesController.cus113 == 0 && CutscenesController.cus112 == 1 && ContainerController.Wood >= 10)
                {
                    CutscenesController.cus113FIndex = 1;
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
                }
                else if (CutscenesController.cus113 == 0 && CutscenesController.cus112 == 1 && ContainerController.Wood < 10)
                {
                    once = 1;
                    show2.SetActive(true);
                    show1.text = "You need at least 10 wood";
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

            if (once == 0 && CutscenesController.cus111 == 1 && CutscenesController.cus112 == 0)
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
            else if (once == 0 && CutscenesController.cus112 == 1 && CutscenesController.cus113 == 0)
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

    IEnumerator DelayChangeCutscense()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Cutscenes");
    }
}
