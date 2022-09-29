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
            HPMPBarController.EIndex = 3;
            SceneManager.LoadScene(14);
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
