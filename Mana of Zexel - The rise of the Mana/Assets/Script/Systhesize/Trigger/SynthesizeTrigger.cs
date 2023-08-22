using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynthesizeTrigger : MonoBehaviour
{
    public GameObject showr2, SaveTextOff, spanel1;
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
        if (pick && Input.GetKeyDown(KeyCode.Space) && HubController.BusyHub == false)
        {
            HubController.BusyHub = true;
            showr2.SetActive(false);
            showr1.text = "";
            spanel1.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = true;
            SaveTextOff.SetActive(false);
            showr2.SetActive(true);
            showr1.text = "Press Space to synthesize";
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = false;
            showr2.SetActive(false);
            showr1.text = "";
        }
    }
}
