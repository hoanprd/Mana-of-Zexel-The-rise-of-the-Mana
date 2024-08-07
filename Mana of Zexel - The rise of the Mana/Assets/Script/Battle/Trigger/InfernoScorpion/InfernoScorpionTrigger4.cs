using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfernoScorpionTrigger4 : MonoBehaviour
{
    public static bool despawn = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
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
            HPMPBarController.EIndex = 4;
            if (Global.EnemyListInfo[3] == 0)
            {
                Global.EnemyListInfo[3] = 1;
            }
            despawn = true;
            SceneManager.LoadScene("BSInfernoScorpion 1");
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
