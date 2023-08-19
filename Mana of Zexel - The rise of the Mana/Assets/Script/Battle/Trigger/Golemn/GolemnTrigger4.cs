using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolemnTrigger4 : MonoBehaviour
{
    public static bool despawnGolemnTrigger4 = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus130 == 0)
        {
            despawnGolemnTrigger4 = true;
        }
        else if (CutscenesController.cus130 == 1 && CutscenesController.cus131 == 0)
        {
            despawnGolemnTrigger4 = false;
        }
        else
        {
            despawnGolemnTrigger4 = true;
        }

        if (despawnGolemnTrigger4 == true)
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
            despawnGolemnTrigger4 = true;
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
