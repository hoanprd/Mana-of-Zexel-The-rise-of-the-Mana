using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheatTrigger : MonoBehaviour
{
    ContainerController cc;

    public AudioSource PickUpFX;
    public Text show1;
    public GameObject show2;
    private bool pick;
    private int once;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<ContainerController>();
        once = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pick && Input.GetKeyDown(KeyCode.Space) && HubController.BusyHub == false && once == 0)
        {
            PickUpFX.Play();
            show2.SetActive(true);
            show1.text = "Wheat +1";
            ContainerController.WheatPick = 1;
            cc.UpdateBagPickUp(true);
            once = 1;
            Invoke("delay1", 1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && CutscenesController.cus139 == 0)
        {
            pick = true;
            show2.SetActive(true);
            show1.text = "Press Space to pick up!";
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && CutscenesController.cus139 == 0)
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
        once = 0;
    }
}
