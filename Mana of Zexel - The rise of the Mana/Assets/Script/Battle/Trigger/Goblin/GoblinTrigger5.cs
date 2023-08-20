using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoblinTrigger5 : MonoBehaviour
{
    public static bool despawnGoblinTrigger5 = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus130 == 0)
        {
            despawnGoblinTrigger5 = true;
        }
        else if (CutscenesController.cus130 == 1 && CutscenesController.cus131 == 0 && GlobalQuest.Goblin5Death == 0)
        {
            despawnGoblinTrigger5 = false;
        }
        else
        {
            despawnGoblinTrigger5 = true;
        }

        if (despawnGoblinTrigger5 == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (battle)
        {
            ContainerController.LoadingOpen = true;
            HPMPBarController.EIndex = 2;
            GlobalQuest.Goblin5Death = 1;
            despawnGoblinTrigger5 = true;
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
