using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenesTrigger : MonoBehaviour
{
    public GameObject FadeInPanel;

    public static int PorridgeSyn, BomSyn;
    public static int GolemnKill, GolemnKillP2, GoblinKillP2, InfernoScorpionKill, InfernoScorpionKillP2, IceFangKill, IceFangKill2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (CutscenesController.cus13 == 0 && CutscenesController.cus12 == 1 && Player.MapIndex == 2)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus15 == 0 && CutscenesController.cus14 == 1 && Player.MapIndex == 2)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus26 == 0 && CutscenesController.cus25 == 1 && Player.MapIndex == 1)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus34 == 0 && CutscenesController.cus33 == 1 && Player.MapIndex == 1)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus37 == 0 && CutscenesController.cus36 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus38 == 0 && CutscenesController.cus37 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus51 == 0 && CutscenesController.cus50 == 1 && Player.MapIndex == 5)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus55 == 0 && CutscenesController.cus54 == 1 && Player.MapIndex == 7)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus60 == 0 && CutscenesController.cus59 == 1 && Player.MapIndex == 8)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus61 == 0 && CutscenesController.cus60 == 1 && Player.MapIndex == 8)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus65 == 0 && CutscenesController.cus64 == 1 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus66 == 0 && CutscenesController.cus65 == 1 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus69 == 0 && CutscenesController.cus68 == 1 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus73 == 0 && CutscenesController.cus72 == 1 && Player.MapIndex == 8)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus76 == 0 && CutscenesController.cus75 == 1 && Player.MapIndex == 8)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus77 == 0 && CutscenesController.cus76 == 1 && Player.MapIndex == 8)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus78 == 0 && CutscenesController.cus77 == 1 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus81 == 0 && CutscenesController.cus80 == 1 && Player.MapIndex == 2)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus84 == 0 && CutscenesController.cus83 == 1 && Player.MapIndex == 10)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus86 == 0 && CutscenesController.cus85 == 1 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus87 == 0 && CutscenesController.cus86 == 1 && ContainerController.ManaCoreIceVayne > 0 && Player.MapIndex == 9)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus89 == 0 && CutscenesController.cus88 == 1 && ContainerController.FireManaGenerator > 0 && Player.MapIndex == 8)
            {
                CutscenesController.cus89FIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus90 == 0 && CutscenesController.cus88 == 1 && ContainerController.IceManaGenerator > 0 && Player.MapIndex == 9)
            {
                CutscenesController.cus90FIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus91 == 0 && CutscenesController.cus90 == 1 && Player.MapIndex == 7)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus95 == 0 && CutscenesController.cus94 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus99 == 0 && CutscenesController.cus98 == 1 && Player.MapIndex == 12)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus105 == 0 && CutscenesController.cus104 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus119 == 0 && CutscenesController.cus118 == 1 && Player.MapIndex == 9)
            {
                CutscenesController.cus119FIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus120 == 0 && CutscenesController.cus119 == 1 && Player.MapIndex == 9)
            {
                CutscenesController.cus120FIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus123 == 0 && CutscenesController.cus122 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus124 == 0 && CutscenesController.cus123 == 1 && Player.MapIndex == 2)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus126 == 0 && CutscenesController.cus125 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus133 == 0 && CutscenesController.cus132 == 1 && Player.MapIndex == 3)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus134 == 0 && CutscenesController.cus133 == 1 && Player.MapIndex == 7)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus135 == 0 && CutscenesController.cus134 == 1 && Player.MapIndex == 11)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus136 == 0 && CutscenesController.cus135 == 1 && Player.MapIndex == 11)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus137 == 0 && CutscenesController.cus136 == 1 && Player.MapIndex == 11)
            {
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus141 == 0 && CutscenesController.cus140 == 1 && Player.MapIndex == 7)
            {
                StartCoroutine(DelayChangeCutscense());
            }
        }
    }

    IEnumerator DelayChangeCutscense()
    {
        FadeInPanel.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Cutscenes");
    }
}
