using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop1 : MonoBehaviour
{
    public Text show1;
    public GameObject show2;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus113 == 1)
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            show2.SetActive(true);
            show1.text = "You can't go to this area yet!";
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            show2.SetActive(false);
        }
    }
}
