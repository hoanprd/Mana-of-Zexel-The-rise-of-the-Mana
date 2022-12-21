using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutscenesTrigger : MonoBehaviour
{
    public static int GolemnKill;

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
        if (collision.CompareTag("Cutscene"))
        {
            if (CutscenesController.cus13 == 0 && CutscenesController.cus12 == 1 && Player.MapIndex == 2)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus15 == 0 && CutscenesController.cus14 == 1 && Player.MapIndex == 2)
            {
                SceneManager.LoadScene("Cutscenes");
            }
        }
    }
}
