using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraCutscenesTrigger : MonoBehaviour
{
    public GameObject FadeInPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (ExtraCutscenesController.cuse1 == 0 && CutscenesController.cus11 == 1 && CutscenesController.cus137 == 0 && Player.MapIndex == 0)
            {
                if (CutscenesController.cus93 == 0 || CutscenesController.cus103 == 1)
                {
                    ExtraCutscenesController.cuse1 = 1;
                    ExtraCutscenesController.CEIndex = 1;
                    StartCoroutine(DelayChangeCutscense());
                }
            }
            else if (ExtraCutscenesController.cuse2 == 0 && CutscenesController.cus21 == 1 && CutscenesController.cus137 == 0 && Player.MapIndex == 1)
            {
                ExtraCutscenesController.cuse2 = 1;
                ExtraCutscenesController.CEIndex = 2;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (ExtraCutscenesController.cuse3 == 0 && CutscenesController.cus85 == 1 && CutscenesController.cus137 == 0 && Player.MapIndex == 10)
            {
                ExtraCutscenesController.cuse3 = 1;
                ExtraCutscenesController.CEIndex = 3;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (ExtraCutscenesController.cuse4 == 0 && CutscenesController.cus105 == 1 && CutscenesController.cus137 == 0 && Player.MapIndex == 12)
            {
                ExtraCutscenesController.cuse4 = 1;
                ExtraCutscenesController.CEIndex = 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (ExtraCutscenesController.cuse5 == 0 && CutscenesController.cus105 == 1 && CutscenesController.cus137 == 0 && Player.MapIndex == 11)
            {
                ExtraCutscenesController.cuse5 = 1;
                ExtraCutscenesController.CEIndex = 5;
                StartCoroutine(DelayChangeCutscense());
            }
        }
    }

    IEnumerator DelayChangeCutscense()
    {
        FadeInPanel.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Extra cutscenes");
    }
}
