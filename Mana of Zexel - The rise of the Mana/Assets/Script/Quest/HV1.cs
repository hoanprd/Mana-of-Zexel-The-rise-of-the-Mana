using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HV1 : MonoBehaviour
{
    public Text show1;
    public GameObject show2;
    private bool pick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pick && Input.GetKeyDown(KeyCode.Space) && CutscenesController.cus8 == 1 && ContainerController.ElixirPotion > 0 && GlobalQuest.HelpVillagerStop1 == 0)
        {
            GlobalQuest.HelpVillagerStop1 = 1;
            show2.SetActive(true);
            show1.text = "Help +1";
            ContainerController.ElixirPotion -= 1;
            GlobalQuest.HelpVillagerDone += 1;
            Invoke("delay1", 1f);
        }
        if (GlobalQuest.HelpVillagerDone == 3 && GlobalQuest.HelpVillagerStop1 == 1 && GlobalQuest.HelpVillagerStop2 == 1 && GlobalQuest.HelpVillagerStop3 == 1)
        {
            GlobalQuest.HelpVillagerStop1 = 2;
            GlobalQuest.HelpVillagerStop2 = 2;
            GlobalQuest.HelpVillagerStop3 = 2;
            SceneManager.LoadScene("Cutscenes");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = true;
        }
    }
    void delay1()
    {
        show2.SetActive(false);
    }
}
