using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoblinTrigger6 : MonoBehaviour
{
    public static bool despawnGoblinTrigger6 = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus108 == 0)
        {
            despawnGoblinTrigger6 = true;
        }
        else if (CutscenesController.cus108 == 1 && CutscenesController.cus109 == 0)
        {
            despawnGoblinTrigger6 = false;
        }
        else
        {
            despawnGoblinTrigger6 = true;
        }

        if (despawnGoblinTrigger6 == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (battle && Input.GetKeyDown(KeyCode.Space))
        {
            HPMPBarController.EIndex = 2;
            despawnGoblinTrigger6 = true;
            SceneManager.LoadScene("BSGoblin 1");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            battle = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            battle = false;
        }
    }
}
