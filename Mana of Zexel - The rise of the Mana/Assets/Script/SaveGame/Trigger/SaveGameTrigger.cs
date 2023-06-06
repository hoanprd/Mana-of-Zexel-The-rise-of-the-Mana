using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameTrigger : MonoBehaviour
{
    public GameObject SaveGamePanel;
    private bool pick;
    //private int once = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pick && Input.GetKeyDown(KeyCode.Space))
        {
            //once = 1;
            HubController.BusyHub = true;
            SaveGamePanel.SetActive(true);
            //Invoke("delay1", 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pick = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pick = false;
        }
    }
    void delay1()
    {
        //Destroy(gameObject);
        //once = 0;
    }
}
