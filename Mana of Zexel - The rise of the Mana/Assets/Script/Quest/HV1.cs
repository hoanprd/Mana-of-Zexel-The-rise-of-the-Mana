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
        else if (pick && Input.GetKeyDown(KeyCode.Space) && CutscenesController.cus8 == 1 && ContainerController.ElixirPotion <= 0 && GlobalQuest.HelpVillagerStop1 == 0)
        {
            show2.SetActive(true);
            show1.text = "You don't have enough elixir potion";
            Invoke("delay1", 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (CutscenesController.cus9 == 0 && CutscenesController.cus8 == 1 && GlobalQuest.HelpVillagerStop1 == 0)
            {
                pick = true;
                show2.SetActive(true);
                show1.text = "Press Space to commit the elixir potion";
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = false;
            show2.SetActive(false);
            show1.text = "";
        }
    }

    void delay1()
    {
        show2.SetActive(false);

        if (GlobalQuest.HelpVillagerDone == 3 && GlobalQuest.HelpVillagerStop1 == 1 && GlobalQuest.HelpVillagerStop2 == 1 && GlobalQuest.HelpVillagerStop3 == 1)
        {
            GlobalQuest.HelpVillagerStop1 = 2;
            GlobalQuest.HelpVillagerStop2 = 2;
            GlobalQuest.HelpVillagerStop3 = 2;
            SceneManager.LoadScene("Cutscenes");
        }
    }
}
