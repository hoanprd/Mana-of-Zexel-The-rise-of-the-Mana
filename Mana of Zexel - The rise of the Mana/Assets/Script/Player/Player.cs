using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float move_speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Text show1;
    public GameObject show2;
    public Text show3;
    public GameObject show4;
    private bool heal, tqz, mqz;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        if (heal && Input.GetKeyDown(KeyCode.Space))
        {
            if (Global.Zen >= 100)
            {
                show2.SetActive(true);
                show1.text = "-100 Zen";
                Global.Zen -= 100;
                Global.CurHPP1 = Global.MaxHPP1;
                Global.CurMPP1 = Global.MaxMPP1;
                Global.CurHPP2 = Global.MaxHPP2;
                Global.CurMPP2 = Global.MaxMPP2;
                Invoke("delay1", 2f);
            }
            else
            {
                show2.SetActive(true);
                show1.text = "Not enough Zen!";
                Invoke("delay1", 2f);
            }
        }
        if (tqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus4 == 1 && CutscenesController.cus6 == 0)
            {
                if (ContainerController.HealPotion > 0)
                {
                    ContainerController.HealPotion -= 1;
                    SceneManager.LoadScene(9);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "Not enough heal potion!";
                    Invoke("delay1", 2f);
                }
            }
            else if (CutscenesController.cus6 == 1 && CutscenesController.cus7 == 0)
            {
                if (GlobalQuest.KillGoblinQuest == 4)
                {
                    SceneManager.LoadScene(9);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You need to defeat at least 4 goblins";
                    Invoke("delay1", 2f);
                }
            }
        }
        if (mqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus11 == 0)
            {
                SceneManager.LoadScene(9);
            }
            else if (CutscenesController.cus11 == 1)
            {
                if (ContainerController.ManaGem >= 3)
                {
                    ContainerController.ManaGem -= 3;
                    SceneManager.LoadScene(9);
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You don't have enough 3 mana gem!";
                    Invoke("delay1", 2f);
                }
            }
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastY", Input.GetAxisRaw("Vertical"));
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("WishingHillToZexelTown"))
        {
            MapController.WishingHillToZexelTown = true;
            ThiefTrigger1.despawn = false;
            ThiefTrigger2.despawn = false;
            ThiefTrigger3.despawn = false;
            if (CutscenesController.cus3 == 0)
                SceneManager.LoadScene(9);
            else
                SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("ZexelTownToWishingHill"))
        {
            MapController.ZexelTownToWishingHill = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            SceneManager.LoadScene(2);
        }
        if (collision.CompareTag("ZexelTownToTavern"))
        {
            MapController.ZexelTownToTavern = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            if (CutscenesController.cus4 == 0)
                SceneManager.LoadScene(9);
            else
                SceneManager.LoadScene(5);
        }
        if (collision.CompareTag("TavernToZexelTown"))
        {
            MapController.TavernToZexelTown = true;
            if (CutscenesController.cus7 == 1 && CutscenesController.cus8 == 0)
                SceneManager.LoadScene(9);
            else
                SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("TavernToSaveRoom"))
        {
            MapController.TavernToSaveRoom = true;
            if (CutscenesController.cus5 == 0)
                SceneManager.LoadScene(9);
            else
                SceneManager.LoadScene(6);
        }
        if (collision.CompareTag("SaveRoomToTavern"))
        {
            MapController.SaveRoomToTavern = true;
            SceneManager.LoadScene(5);
        }
        if (collision.CompareTag("ZexelTownToGroceryStore") && CutscenesController.cus19 == 1)
        {
            MapController.ZexelTownToGroceryStore = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            SceneManager.LoadScene(7);
        }
        if (collision.CompareTag("GroceryStoreToZexelTown"))
        {
            MapController.GroceryStoreToZexelTown = true;
            SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("ZexelTownToWeaponStore") && CutscenesController.cus20 == 1)
        {
            MapController.ZexelTownToWeaponStore = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            SceneManager.LoadScene(8);
        }
        if (collision.CompareTag("WeaponStoreToZexelTown"))
        {
            MapController.WeaponStoreToZexelTown = true;
            SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("ZexelTownToWishingForest"))
        {
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            if (CutscenesController.cus9 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else
            {
                if (CutscenesController.cus10 == 0)
                {
                    MapController.ZexelTownToWishingForest = true;
                    SceneManager.LoadScene(9);
                }
                else
                {
                    MapController.ZexelTownToWishingForest = true;
                    SceneManager.LoadScene(4);
                }
            }
        }
        if (collision.CompareTag("WishingForestToZexelTown"))
        {
            MapController.WishingForestToZexelTown = true;
            GolemnTrigger1.despawn = false;
            GolemnTrigger2.despawn = false;
            GolemnTrigger3.despawn = false;
            SceneManager.LoadScene(3);
        }
        if (collision.CompareTag("HealPoint"))
        {
            heal = true;
        }
        if (collision.CompareTag("TQZ"))
        {
            tqz = true;
        }
        if (collision.CompareTag("MQZ"))
        {
            mqz = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("HealPoint"))
        {
            heal = false;
        }
        if (collision.CompareTag("TQZ"))
        {
            tqz = false;
        }
        if (collision.CompareTag("MQZ"))
        {
            mqz = false;
        }
    }
    void delay1()
    {
        show2.SetActive(false);
    }
    void delay2()
    {
        show4.SetActive(false);
    }
}
