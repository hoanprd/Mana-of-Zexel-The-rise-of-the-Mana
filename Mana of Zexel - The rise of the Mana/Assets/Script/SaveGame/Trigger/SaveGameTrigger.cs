using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGameTrigger : MonoBehaviour
{
    public GameObject showr2, SaveGamePanel;
    public Text showr1;
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
            showr2.SetActive(false);
            showr1.text = "";
            SaveGamePanel.SetActive(true);
            //Invoke("delay1", 1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pick = true;
            showr2.SetActive(true);
            showr1.text = "Press Space to save game";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pick = false;
            showr2.SetActive(false);
            showr1.text = "";
        }
    }
    void delay1()
    {
        //Destroy(gameObject);
        //once = 0;
    }
}
