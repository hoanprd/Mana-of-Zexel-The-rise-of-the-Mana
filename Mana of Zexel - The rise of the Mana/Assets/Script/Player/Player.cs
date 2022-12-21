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
    private bool heal, tqz, mqz, klener;
    public static int MapIndex;
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
                    SceneManager.LoadScene("Cutscenes");
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
                    SceneManager.LoadScene("Cutscenes");
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
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus11 == 1)
            {
                if (ContainerController.ManaGem >= 3)
                {
                    ContainerController.ManaGem -= 3;
                    SceneManager.LoadScene("Cutscenes");
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You don't have enough 3 mana gem!";
                    Invoke("delay1", 2f);
                }
            }
        }

        if (klener && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus19 == 0 && CutscenesController.cus18 == 1 && ContainerController.HealPotion > 1 && ContainerController.ManaCloth > 1)
            {
                SceneManager.LoadScene("Cutscenes");
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
            MapIndex = 1;
            if (CutscenesController.cus3 == 0)
                SceneManager.LoadScene("Cutscenes");
            else
                SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("ZexelTownToWishingHill"))
        {
            MapController.ZexelTownToWishingHill = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            MapIndex = 0;
            SceneManager.LoadScene("Wishing hill");
        }
        if (collision.CompareTag("ZexelTownToTavern"))
        {
            MapController.ZexelTownToTavern = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            if (CutscenesController.cus4 == 0)
                SceneManager.LoadScene("Cutscenes");
            else if (CutscenesController.cus16 == 0 && CutscenesController.cus15 == 1 && ContainerController.String >= 2)
            {
                ContainerController.String -= 4;
                SceneManager.LoadScene("Cutscenes");
            }
            else if (CutscenesController.cus17 == 0 && CutscenesController.cus16 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else
                SceneManager.LoadScene("Tavern");
        }
        if (collision.CompareTag("TavernToZexelTown"))
        {
            MapController.TavernToZexelTown = true;
            if (CutscenesController.cus7 == 1 && CutscenesController.cus8 == 0)
                SceneManager.LoadScene("Cutscenes");
            else if (CutscenesController.cus18 == 0 && CutscenesController.cus17 == 1)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else
                SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("TavernToSaveRoom"))
        {
            MapController.TavernToSaveRoom = true;
            if (CutscenesController.cus5 == 0)
                SceneManager.LoadScene("Cutscenes");
            else
                SceneManager.LoadScene("Save room");
        }
        if (collision.CompareTag("SaveRoomToTavern"))
        {
            MapController.SaveRoomToTavern = true;
            SceneManager.LoadScene("Tavern");
        }
        if (collision.CompareTag("ZexelTownToGroceryStore") && CutscenesController.cus19 == 1)
        {
            MapController.ZexelTownToGroceryStore = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            SceneManager.LoadScene("GroceryStore");
        }
        if (collision.CompareTag("GroceryStoreToZexelTown"))
        {
            MapController.GroceryStoreToZexelTown = true;
            SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("ZexelTownToWeaponStore") && CutscenesController.cus20 == 1)
        {
            MapController.ZexelTownToWeaponStore = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            SceneManager.LoadScene("WeaponStore");
        }
        if (collision.CompareTag("WeaponStoreToZexelTown"))
        {
            MapController.WeaponStoreToZexelTown = true;
            SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("ZexelTownToWishingForest"))
        {
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            MapIndex = 2;
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
                    SceneManager.LoadScene("Cutscenes");
                }
                else
                {
                    MapController.ZexelTownToWishingForest = true;
                    SceneManager.LoadScene("Wishing forest");
                }
            }
        }
        if (collision.CompareTag("WishingForestToZexelTown"))
        {
            MapController.WishingForestToZexelTown = true;
            GolemnTrigger1.despawn = false;
            GolemnTrigger2.despawn = false;
            GolemnTrigger3.despawn = false;
            MapIndex = 1;
            SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("ZexelTownToInfernoDesert"))
        {
            MapController.ZexelTownToInfernoDesert = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToZexelTown"))
        {
            MapController.InfernoDesertToZexelTown = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 1;
            SceneManager.LoadScene("Zexel town");
        }
        if (collision.CompareTag("InfernoDesertToZexelGate"))
        {
            MapController.InfernoDesertToZexelGate = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 4;
            SceneManager.LoadScene("Zexel gate");
        }
        if (collision.CompareTag("ZexelGateToInfernoDesert"))
        {
            MapController.ZexelGateToInfernoDesert = true;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToManaGate"))
        {
            MapController.InfernoDesertToManaGate = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 5;
            SceneManager.LoadScene("Mana gate");
        }
        if (collision.CompareTag("ManaGateToInfernoDesert"))
        {
            MapController.ManaGateToInfernoDesert = true;
            ManaSlimeTrigger1.despawn = false;
            ManaSlimeTrigger2.despawn = false;
            ManaSlimeTrigger3.despawn = false;
            ManaSlimeTrigger4.despawn = false;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToInfernoVolcano"))
        {
            MapController.InfernoDesertToInfernoVolcano = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 8;
            SceneManager.LoadScene("Inferno volcano");
        }
        if (collision.CompareTag("InfernoVolcanoToInfernoDesert"))
        {
            MapController.InfernoVolcanoToInfernoDesert = true;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToInfernoIce"))
        {
            MapController.InfernoDesertToInfernoIce = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 9;
            SceneManager.LoadScene("Inferno ice");
        }
        if (collision.CompareTag("InfernoIceToInfernoDesert"))
        {
            MapController.InfernoIceToInfernoDesert = true;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToManaCliff"))
        {
            MapController.InfernoDesertToManaCliff = true;
            InfernoScorpionTrigger1.despawn = false;
            InfernoScorpionTrigger2.despawn = false;
            InfernoScorpionTrigger3.despawn = false;
            InfernoScorpionTrigger4.despawn = false;
            InfernoScorpionTrigger5.despawn = false;
            InfernoScorpionTrigger6.despawn = false;
            MapIndex = 12;
            SceneManager.LoadScene("Mana cliff");
        }
        if (collision.CompareTag("ManaCliffToInfernoDesert"))
        {
            MapController.ManaCliffToInfernoDesert = true;
            MapIndex = 3;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("ManaGateToManaDimension"))
        {
            MapController.ManaGateToManaDimension = true;
            ManaSlimeTrigger1.despawn = false;
            ManaSlimeTrigger2.despawn = false;
            ManaSlimeTrigger3.despawn = false;
            ManaSlimeTrigger4.despawn = false;
            MapIndex = 6;
            SceneManager.LoadScene("Mana dimension");
        }
        if (collision.CompareTag("ManaDimensionToManaGate"))
        {
            MapController.ManaDimensionToManaGate = true;
            MapIndex = 5;
            SceneManager.LoadScene("Mana gate");
        }
        if (collision.CompareTag("ManaDimensionToManaTemple"))
        {
            MapController.ManaDimensionToManaTemple = true;
            MapIndex = 7;
            SceneManager.LoadScene("Mana temple");
        }
        if (collision.CompareTag("ManaTempleToManaDimension"))
        {
            MapController.ManaTempleToManaDimension = true;
            MapIndex = 6;
            SceneManager.LoadScene("Mana dimension");
        }
        if (collision.CompareTag("InfernoVolcanoToInsideVolcanoCave"))
        {
            MapController.InfernoVolcanoToInsideVolcanoCave = true;
            MapIndex = 8;
            SceneManager.LoadScene("InsideVolcanoCave");
        }
        if (collision.CompareTag("InsideVolcanoCaveToInfernoVolcano"))
        {
            MapController.InsideVolcanoCaveToInfernoVolcano = true;
            MapIndex = 8;
            SceneManager.LoadScene("Inferno volcano");
        }
        if (collision.CompareTag("InfernoVolcanoToAltaInferno"))
        {
            MapController.InfernoVolcanoToAltaInferno = true;
            MapIndex = 10;
            SceneManager.LoadScene("Alta inferno");
        }
        if (collision.CompareTag("AltaInfernoToInfernoVolcano"))
        {
            MapController.AltaInfernoToInfernoVolcano = true;
            MapIndex = 8;
            SceneManager.LoadScene("Inferno volcano");
        }
        if (collision.CompareTag("InfernoIceToInsideIceCave"))
        {
            MapController.InfernoIceToInsideIceCave = true;
            MapIndex = 9;
            SceneManager.LoadScene("InsideIceCave");
        }
        if (collision.CompareTag("InsideIceCaveToInfernoIce"))
        {
            MapController.InsideIceCaveToInfernoIce = true;
            MapIndex = 9;
            SceneManager.LoadScene("Inferno ice");
        }
        if (collision.CompareTag("InfernoIceToAltaInferno"))
        {
            MapController.InfernoIceToAltaInferno = true;
            MapIndex = 10;
            SceneManager.LoadScene("Alta inferno");
        }
        if (collision.CompareTag("AltaInfernoToInfernoIce"))
        {
            MapController.AltaInfernoToInfernoIce = true;
            MapIndex = 9;
            SceneManager.LoadScene("Inferno Ice");
        }
        if (collision.CompareTag("ZexelGateToZexelTemple"))
        {
            MapController.ZexelGateToZexelTemple = true;
            MapIndex = 11;
            SceneManager.LoadScene("Zexel temple");
        }
        if (collision.CompareTag("ZexelTempleToZexelGate"))
        {
            MapController.ZexelTempleToZexelGate = true;
            MapIndex = 4;
            SceneManager.LoadScene("Zexel gate");
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Klener"))
        {
            klener = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            klener = false;
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
