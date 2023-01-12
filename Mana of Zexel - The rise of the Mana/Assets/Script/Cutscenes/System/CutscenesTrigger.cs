using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenesTrigger : MonoBehaviour
{
    public static int PorridgeSyn, BomSyn;
    public static int GolemnKill, InfernoScorpionKill, InfernoScorpionKillP2;

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
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus15 == 0 && CutscenesController.cus14 == 1 && Player.MapIndex == 2)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus26 == 0 && CutscenesController.cus25 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus34 == 0 && CutscenesController.cus33 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus37 == 0 && CutscenesController.cus36 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus38 == 0 && CutscenesController.cus37 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus51 == 0 && CutscenesController.cus50 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus55 == 0 && CutscenesController.cus54 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus60 == 0 && CutscenesController.cus59 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus61 == 0 && CutscenesController.cus60 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus65 == 0 && CutscenesController.cus64 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
        }
    }
}
