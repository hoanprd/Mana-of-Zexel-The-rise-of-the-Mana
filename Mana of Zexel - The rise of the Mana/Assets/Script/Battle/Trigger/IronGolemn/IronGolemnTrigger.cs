using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IronGolemnTrigger : MonoBehaviour
{
    public GameObject IronGolemn;
    public static bool despawn = false;
    private bool battle;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus14 == 0)
        {
            IronGolemn.SetActive(false);
        }

        if (despawn == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (battle && Input.GetKeyDown(KeyCode.Space))
        {
            ContainerController.LoadingOpen = true;
            HPMPBarController.EIndex = 24;
            despawn = true;
            SceneManager.LoadScene("BSIronGolemn 1");
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
