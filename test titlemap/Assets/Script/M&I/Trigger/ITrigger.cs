using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITrigger : MonoBehaviour
{
    public Text show1;
    public GameObject show2;
    private bool pick;
    private int once=0;
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
            show1.text = "Iron +1";
            //PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("SI") + 1);
            ContainerController.Iron += 1;
            once = 1;
            Invoke("delay1", 1f);
            Debug.Log(PlayerPrefs.GetInt("SDL"));
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
        show2.SetActive(false);
        Destroy(gameObject);
        once = 0;
    }
}
