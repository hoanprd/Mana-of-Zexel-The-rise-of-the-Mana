using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IIVMan2 : MonoBehaviour
{
    public Text show1;
    public GameObject show2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (CutscenesController.cus119 == 0 && CutscenesController.cus118 == 1)
            {
                show2.SetActive(true);
                show1.text = "He needs to find his lost wedding ring to get back to his wife";
            }
            else if (CutscenesController.cus120 == 0 && CutscenesController.cus119 == 1)
            {
                show2.SetActive(true);
                show1.text = "Time to return him to his wife this time";
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            show2.SetActive(false);
        }
    }
}
