using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WFPW : MonoBehaviour
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
                if (CutscenesController.cus82 == 0 && CutscenesController.cus81 == 1)
                {
                    SceneManager.LoadScene("Cutscenes");
                }
                else
                {
                    once = 1;
                    show1.text = "You don't have enough items";
                    show2.SetActive(true);
                    Invoke("delay1", 2f);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsReady = true;
            if (once == 0)
            {
                show2.SetActive(true);
                show1.text = "Press Space to delivery special back pain";
            }
            else
            {
                show2.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsReady = false;
            show2.SetActive(false);
        }
    }

    void delay1()
    {
        once = 0;
        show2.SetActive(true);
    }
}
