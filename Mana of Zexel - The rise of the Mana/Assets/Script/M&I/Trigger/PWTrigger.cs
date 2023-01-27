using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PWTrigger : MonoBehaviour
{
    public Text show1;
    public GameObject show2;

    private bool pick;
    private int once = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pick && Input.GetKeyDown(KeyCode.Space) && once == 0)
        {
            show2.SetActive(true);
            show1.text = "Pure water +1";
            ContainerController.PureWaterPick = 1;
            once = 1;
            Invoke("delay1", 1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = true;
            show2.SetActive(true);
            show1.text = "Press Space to pick up!";
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = false;
            if (once == 0)
            {
                show2.SetActive(false);
            }
        }
    }
    void delay1()
    {
        show2.SetActive(false);
        //Destroy(gameObject);
        once = 0;
    }
}
