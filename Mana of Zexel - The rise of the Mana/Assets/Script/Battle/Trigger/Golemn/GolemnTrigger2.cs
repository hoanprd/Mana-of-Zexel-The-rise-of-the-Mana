using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolemnTrigger2 : MonoBehaviour
{
    public static bool despawn = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus130 == 1 && CutscenesController.cus131 == 0)
        {
            despawn = true;
        }

        if (despawn == true)
        {
            Destroy(gameObject);
        }

        if (CutscenesController.cus139 == 1)
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
            if (Global.EnemyListInfo[2] == 0)
            {
                Global.EnemyListInfo[2] = 1;
            }
            despawn = true;
            SceneManager.LoadScene("BSGolemn 1");
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
