using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolemnTrigger5 : MonoBehaviour
{
    public static bool despawnGolemnTrigger5 = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus130 == 0)
        {
            despawnGolemnTrigger5 = true;
        }
        else if (CutscenesController.cus130 == 1 && CutscenesController.cus131 == 0 && GlobalQuest.Golemn5Death == 0)
        {
            despawnGolemnTrigger5 = false;
        }
        else
        {
            despawnGolemnTrigger5 = true;
        }

        if (despawnGolemnTrigger5 == true)
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
            HPMPBarController.EIndex = 3;
            GlobalQuest.Golemn5Death = 1;
            despawnGolemnTrigger5 = true;
            SceneManager.LoadScene("BSGolemn 2");
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
