using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynthesizeTrigger : MonoBehaviour
{
    public GameObject spanel1;
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
            spanel1.SetActive(true);
            Invoke("delay1", 1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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
