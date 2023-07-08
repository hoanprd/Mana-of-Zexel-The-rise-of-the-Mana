using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool FootStepIndex;
    public float move_speed = 5f;
    public int OnceFootStep = 0, once;
    public Rigidbody2D rb;
    public Animator animator;

    public Text show1;
    public GameObject show2;
    public Text show3;
    public GameObject show4;
    public GameObject FadeOutPanel, FadeInPanel;
    private bool heal, tqz, mqz, alasaqz, asilaqz, klener, mwqz, ManaGenerator, FireManaGenerator, IceManaGenerator;
    public static int MapIndex;
    public AudioSource FootStep;
    Vector2 movement;

    void Start()
    {
        FadeOutPanel.SetActive(true);
        once = 0;
        StartCoroutine(DelayFadeOutOff());
    }

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
            if (CutscenesController.cus4 == 1 && CutscenesController.cus5 == 1 && CutscenesController.cus6 == 0)
            {
                if (ContainerController.HealPotion > 0)
                {
                    ContainerController.HealPotion -= 1;
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
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
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
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
                    FadeInPanel.SetActive(true);
                    ContainerController.ManaGem -= 3;
                    StartCoroutine(DelayChangeCutscense());
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You don't have enough 3 mana gem!";
                    Invoke("delay1", 2f);
                }
            }
        }
        if (alasaqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1 && CutscenesTrigger.IceFangKill >= 4)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1 && CutscenesTrigger.IceFangKill < 4)
            {
                show2.SetActive(true);
                show1.text = "The number of ice fangs is still not enough. Remain: " + CutscenesTrigger.IceFangKill;
                Invoke("delay1", 2f);
            }

            if (CutscenesController.cus70 == 0 && CutscenesController.cus69 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus70 == 0 && CutscenesController.cus69 == 0 && CutscenesController.cus68 == 0)
            {
                show2.SetActive(true);
                show1.text = "You still haven't found the ice crystal";
                Invoke("delay1", 2f);
            }
        }
        if (asilaqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus71 == 0 && CutscenesController.cus70 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus77 == 0 && CutscenesController.cus76 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
        }

        if (klener && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus19 == 0 && CutscenesController.cus18 == 1)
            {
                if (ContainerController.HealPotion >= 1 && ContainerController.ManaCloth >= 1)
                {
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "Not enough items";
                    Invoke("delay1", 2f);
                }
            }
            else if (CutscenesController.cus22 == 0 && CutscenesController.cus21 == 1)
            {
                if (ContainerController.ManaShield >= 1)
                {
                    FadeInPanel.SetActive(true);
                    StartCoroutine(DelayChangeCutscense());
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "Not enough items";
                    Invoke("delay1", 2f);
                }
            }
        }

        if (mwqz && Input.GetKeyDown(KeyCode.Space))
        {
            if (CutscenesController.cus82 == 0)
            {
                if (ContainerController.BackPainMedicine >= 1)
                {
                    FadeInPanel.SetActive(true);
                    ContainerController.BackPainMedicine -= 1;
                    StartCoroutine(DelayChangeCutscense());
                }
                else
                {
                    show2.SetActive(true);
                    show1.text = "You don't have enough back pain medicine!";
                    Invoke("delay1", 2f);
                }
            }
        }

        if (ManaGenerator && Input.GetKeyDown(KeyCode.Space))
        {
            SynthesizeSystem.ManaSynthesize = 100;
            show2.SetActive(true);
            show1.text = "Mana restore!";
            Invoke("delay1", 2f);
        }

        if (FireManaGenerator && Input.GetKeyDown(KeyCode.Space))
        {
            SynthesizeSystem.ManaSynthesize = 100;
            show2.SetActive(true);
            show1.text = "Fire mana restore!";
            Invoke("delay1", 2f);
        }

        if (IceManaGenerator && Input.GetKeyDown(KeyCode.Space))
        {
            SynthesizeSystem.ManaSynthesize = 100;
            show2.SetActive(true);
            show1.text = "Ice mana restore!";
            Invoke("delay1", 2f);
        }

        if (FadeInPanel.activeSelf == true || FadeOutPanel.activeSelf == true)
        {
            HubController.BusyHub = true;
        }

        if (HubController.BusyHub == false && ContainerController.LoadingOpen == false && FadeInPanel.activeSelf == false && FadeOutPanel.activeSelf == false)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                FootStepIndex = true;
                animator.SetFloat("LastX", Input.GetAxisRaw("Horizontal"));
                animator.SetFloat("LastY", Input.GetAxisRaw("Vertical"));
            }
            else
            {
                FootStepIndex = false;
            }
            animator.SetFloat("Speed", movement.sqrMagnitude);

            if (FootStepIndex == true && OnceFootStep == 0)
            {
                OnceFootStep = 1;
                FootStep.Play();
            }
            else if (FootStepIndex == false)
            {
                OnceFootStep = 0;
                FootStep.Stop();
            }
        }
        else
        {
            OnceFootStep = 0;
            FootStep.Stop();
        }

        /*movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastY", Input.GetAxisRaw("Vertical"));
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);*/
    }

    void FixedUpdate()
    {
        if (HubController.BusyHub == false)
        {
            rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
        }
        //rb.MovePosition(rb.position + movement * move_speed * Time.fixedDeltaTime);
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
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());

            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("ZexelTownToWishingHill"))
        {
            if (CutscenesController.cus143 == 0 && CutscenesController.cus142 == 1)
            {
                MapController.ZexelTownToWishingHill = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                MapIndex = 0;
                FadeInPanel.SetActive(true);
                //ContainerController.LoadingOpen = true;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.ZexelTownToWishingHill = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                MapIndex = 0;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing hill");
            }
        }
        if (collision.CompareTag("ZexelTownToTavern"))
        {
            MapController.ZexelTownToTavern = true;
            GoblinTrigger1.despawn = false;
            GoblinTrigger2.despawn = false;
            GoblinTrigger3.despawn = false;
            GoblinTrigger4.despawn = false;
            if (CutscenesController.cus4 == 0 && CutscenesController.cus3 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus16 == 0 && CutscenesController.cus15 == 1 && ContainerController.String >= 2)
            {
                FadeInPanel.SetActive(true);
                ContainerController.String -= 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus17 == 0 && CutscenesController.cus16 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus21 == 0 && CutscenesController.cus20 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus30 == 0 && CutscenesController.cus29 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus39 == 0 && CutscenesController.cus38 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus42 == 0 && CutscenesController.cus41 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus56 == 0 && CutscenesController.cus55 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus58 == 0 && CutscenesController.cus57 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus80 == 0 && CutscenesController.cus79 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus88 == 0 && CutscenesController.cus87 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus94 == 0 && CutscenesController.cus93 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus96 == 0 && CutscenesController.cus95 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus97 == 0 && CutscenesController.cus96 == 1 && ContainerController.NatureGrass >= 4 && ContainerController.RedManaSlimeBall >= 4 && ContainerController.BlueManaSlimeBall >= 4 && ContainerController.ScorpionVenom >= 4)
            {
                FadeInPanel.SetActive(true);
                ContainerController.NatureGrass -= 4;
                ContainerController.RedManaSlimeBall -= 4;
                ContainerController.BlueManaSlimeBall -= 4;
                ContainerController.ScorpionVenom -= 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus101 == 0 && CutscenesController.cus100 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus103 == 0 && CutscenesController.cus102 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus106 == 0 && CutscenesController.cus105 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus142 == 0 && CutscenesController.cus141 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        if (collision.CompareTag("TavernToZexelTown"))
        {
            MapController.TavernToZexelTown = true;
            if (CutscenesController.cus7 == 1 && CutscenesController.cus8 == 0)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus18 == 0 && CutscenesController.cus17 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus102 == 0 && CutscenesController.cus101 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("TavernToSaveRoom"))
        {
            MapController.TavernToSaveRoom = true;
            if (CutscenesController.cus5 == 0)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus24 == 0 && CutscenesController.cus23 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus47 == 0 && CutscenesController.cus46 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Save room");
            }
        }
        if (collision.CompareTag("SaveRoomToTavern"))
        {
            MapController.SaveRoomToTavern = true;
            if (CutscenesController.cus23 == 0 && CutscenesController.cus22 == 1 && CutscenesTrigger.PorridgeSyn == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus31 == 0 && CutscenesController.cus30 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        if (collision.CompareTag("ZexelTownToGroceryStore") && CutscenesController.cus19 == 1 && CutscenesController.cus140 == 0)
        {
            if (CutscenesController.cus32 == 0 && CutscenesController.cus31 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus33 == 0 && CutscenesController.cus32 == 1 && ContainerController.String >= 2 && ContainerController.Iron >= 3 && ContainerController.Wood >= 2)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                ContainerController.String -= 2;
                ContainerController.Iron -= 3;
                ContainerController.Wood -= 2;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus43 == 0 && CutscenesController.cus42 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus45 == 0 && CutscenesController.cus44 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                ContainerController.ScorpionVenom -= 3;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus98 == 0 && CutscenesController.cus97 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus109 == 0 && CutscenesController.cus108 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToGroceryStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                SceneManager.LoadScene("GroceryStore");
            }
        }
        if (collision.CompareTag("GroceryStoreToZexelTown"))
        {
            if (CutscenesController.cus46 == 0 && CutscenesController.cus45 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.GroceryStoreToZexelTown = true;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                MapController.GroceryStoreToZexelTown = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("ZexelTownToWeaponStore") && CutscenesController.cus20 == 1 && CutscenesController.cus140 == 0)
        {
            if (CutscenesController.cus27 == 0 && CutscenesController.cus26 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus28 == 0 && CutscenesController.cus27 == 1 && ContainerController.Iron >= 3 && ContainerController.ManaGem >= 2)
            {
                FadeInPanel.SetActive(true);
                ContainerController.Iron -= 3;
                ContainerController.ManaGem -= 2;
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus62 == 0 && CutscenesController.cus61 == 1 && ContainerController.FireOre >= 4)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                ContainerController.FireOre -= 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus107 == 0 && CutscenesController.cus106 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus108 == 0 && CutscenesController.cus107 == 1 && ContainerController.FireOre >= 3 && ContainerController.RedManaCrystal >= 3 && ContainerController.IceOre >= 3 && ContainerController.BlueManaCrystal >= 3 && ContainerController.ManaDust >= 3)
            {
                FadeInPanel.SetActive(true);
                ContainerController.FireOre -= 3;
                ContainerController.RedManaCrystal -= 3;
                ContainerController.IceOre -= 3;
                ContainerController.BlueManaCrystal -= 3;
                ContainerController.ManaDust -= 3;
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToWeaponStore = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                SceneManager.LoadScene("WeaponStore");
            }
        }
        if (collision.CompareTag("WeaponStoreToZexelTown"))
        {
            if (CutscenesController.cus29 == 0 && CutscenesController.cus28 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.WeaponStoreToZexelTown = true;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus63 == 0 && CutscenesController.cus62 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.WeaponStoreToZexelTown = true;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                MapController.WeaponStoreToZexelTown = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("ZexelTownToWishingForest"))
        {
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
                    FadeInPanel.SetActive(true);
                    MapController.ZexelTownToWishingForest = true;
                    GoblinTrigger1.despawn = false;
                    GoblinTrigger2.despawn = false;
                    GoblinTrigger3.despawn = false;
                    GoblinTrigger4.despawn = false;
                    MapIndex = 2;
                    StartCoroutine(DelayChangeCutscense());
                }
                else
                {
                    MapController.ZexelTownToWishingForest = true;
                    GoblinTrigger1.despawn = false;
                    GoblinTrigger2.despawn = false;
                    GoblinTrigger3.despawn = false;
                    GoblinTrigger4.despawn = false;
                    MapIndex = 2;
                    ContainerController.LoadingOpen = true;
                    SceneManager.LoadScene("Wishing forest");
                }
            }
        }
        if (collision.CompareTag("WishingForestToZexelTown"))
        {
            if (CutscenesController.cus110 == 0 && CutscenesController.cus109 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.WishingForestToZexelTown = true;
                GolemnTrigger1.despawn = false;
                GolemnTrigger2.despawn = false;
                GolemnTrigger3.despawn = false;
                MapIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                MapController.WishingForestToZexelTown = true;
                GolemnTrigger1.despawn = false;
                GolemnTrigger2.despawn = false;
                GolemnTrigger3.despawn = false;
                MapIndex = 1;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("ZexelTownToInfernoDesert"))
        {
            if (CutscenesController.cus34 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus35 == 0 && CutscenesController.cus34 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToInfernoDesert = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                MapIndex = 3;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus104 == 0 && CutscenesController.cus103 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelTownToInfernoDesert = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                MapIndex = 3;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.ZexelTownToInfernoDesert = true;
                GoblinTrigger1.despawn = false;
                GoblinTrigger2.despawn = false;
                GoblinTrigger3.despawn = false;
                GoblinTrigger4.despawn = false;
                MapIndex = 3;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        if (collision.CompareTag("InfernoDesertToZexelTown"))
        {
            if (CutscenesController.cus111 == 0 && CutscenesController.cus110 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToZexelTown = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus130 == 0 && CutscenesController.cus129 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToZexelTown = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus140 == 0 && CutscenesController.cus139 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToZexelTown = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 1;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoDesertToZexelTown = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        if (collision.CompareTag("InfernoDesertToZexelGate"))
        {
            if (CutscenesController.cus40 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus41 == 0 && CutscenesController.cus40 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToZexelGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus92 == 0 && CutscenesController.cus91 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToZexelGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 4;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoDesertToZexelGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 4;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
        if (collision.CompareTag("ZexelGateToInfernoDesert"))
        {
            MapController.ZexelGateToInfernoDesert = true;
            MapIndex = 3;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToManaGate"))
        {
            if (CutscenesController.cus49 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus50 == 0 && CutscenesController.cus49 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToManaGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 5;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus57 == 0 && CutscenesController.cus56 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToManaGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 5;
                StartCoroutine(DelayChangeCutscense());
            }
            else if (CutscenesController.cus141 == 0 && CutscenesController.cus140 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToManaGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 5;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoDesertToManaGate = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 5;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana gate");
            }
        }
        if (collision.CompareTag("ManaGateToInfernoDesert"))
        {
            MapController.ManaGateToInfernoDesert = true;
            ManaSlimeTrigger1.despawn = false;
            ManaSlimeTrigger2.despawn = false;
            ManaSlimeTrigger3.despawn = false;
            ManaSlimeTrigger4.despawn = false;
            MapIndex = 3;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("InfernoDesertToInfernoVolcano"))
        {
            if (CutscenesController.cus58 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus59 == 0 && CutscenesController.cus58 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToInfernoVolcano = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 8;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoDesertToInfernoVolcano = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 8;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        if (collision.CompareTag("InfernoVolcanoToInfernoDesert"))
        {
            FireFangTrigger1.despawn = false;
            FireFangTrigger2.despawn = false;
            FireFangTrigger3.despawn = false;
            FireFangTrigger4.despawn = false;
            MapController.InfernoVolcanoToInfernoDesert = true;
            MapIndex = 3;
            if (CutscenesController.cus122 == 0 && CutscenesController.cus121 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        if (collision.CompareTag("InfernoDesertToInfernoIce"))
        {
            if (CutscenesController.cus63 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus64 == 0 && CutscenesController.cus63 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoDesertToInfernoIce = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 9;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoDesertToInfernoIce = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 9;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        if (collision.CompareTag("InfernoIceToInfernoDesert"))
        {
            MapController.InfernoIceToInfernoDesert = true;
            MapIndex = 3;
            IceFangTrigger1.despawn = false;
            IceFangTrigger2.despawn = false;
            IceFangTrigger3.despawn = false;
            IceFangTrigger4.despawn = false;
            if (CutscenesController.cus122 == 0 && CutscenesController.cus121 == 1)
            {
                FadeInPanel.SetActive(true);
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        if (collision.CompareTag("InfernoDesertToManaCliff"))
        {
            if (CutscenesController.cus93 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else
            {
                MapController.InfernoDesertToManaCliff = true;
                InfernoScorpionTrigger1.despawn = false;
                InfernoScorpionTrigger2.despawn = false;
                InfernoScorpionTrigger3.despawn = false;
                InfernoScorpionTrigger4.despawn = false;
                InfernoScorpionTrigger5.despawn = false;
                InfernoScorpionTrigger6.despawn = false;
                MapIndex = 12;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
        if (collision.CompareTag("ManaCliffToInfernoDesert"))
        {
            MapController.ManaCliffToInfernoDesert = true;
            ManaEagleTrigger1.despawn = false;
            ManaEagleTrigger2.despawn = false;
            ManaEagleTrigger3.despawn = false;
            ManaEagleTrigger4.despawn = false;
            MapIndex = 3;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
        if (collision.CompareTag("ManaGateToManaDimension"))
        {
            if (CutscenesController.cus53 == 0 && CutscenesController.cus52 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ManaGateToManaDimension = true;
                ManaSlimeTrigger1.despawn = false;
                ManaSlimeTrigger2.despawn = false;
                ManaSlimeTrigger3.despawn = false;
                ManaSlimeTrigger4.despawn = false;
                MapIndex = 6;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.ManaGateToManaDimension = true;
                ManaSlimeTrigger1.despawn = false;
                ManaSlimeTrigger2.despawn = false;
                ManaSlimeTrigger3.despawn = false;
                ManaSlimeTrigger4.despawn = false;
                MapIndex = 6;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana dimension");
            }
        }
        if (collision.CompareTag("ManaDimensionToManaGate"))
        {
            MapController.ManaDimensionToManaGate = true;
            MapIndex = 5;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana gate");
        }
        if (collision.CompareTag("ManaDimensionToManaTemple"))
        {
            if (CutscenesController.cus54 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else
            {
                MapController.ManaDimensionToManaTemple = true;
                MapIndex = 7;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
        if (collision.CompareTag("ManaTempleToManaDimension"))
        {
            MapController.ManaTempleToManaDimension = true;
            MapIndex = 6;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana dimension");
        }
        if (collision.CompareTag("InfernoVolcanoToInsideVolcanoCave"))
        {
            if (CutscenesController.cus72 == 0 && CutscenesController.cus71 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoVolcanoToInsideVolcanoCave = true;
                FireFangTrigger1.despawn = false;
                FireFangTrigger2.despawn = false;
                FireFangTrigger3.despawn = false;
                FireFangTrigger4.despawn = false;
                MapIndex = 8;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoVolcanoToInsideVolcanoCave = true;
                FireFangTrigger1.despawn = false;
                FireFangTrigger2.despawn = false;
                FireFangTrigger3.despawn = false;
                FireFangTrigger4.despawn = false;
                MapIndex = 8;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
        if (collision.CompareTag("InsideVolcanoCaveToInfernoVolcano"))
        {
            MapController.InsideVolcanoCaveToInfernoVolcano = true;
            RedManaSlimeTrigger1.despawn = false;
            RedManaSlimeTrigger2.despawn = false;
            RedManaSlimeTrigger3.despawn = false;
            RedManaSlimeTrigger4.despawn = false;
            MapIndex = 8;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno volcano");
        }
        if (collision.CompareTag("InfernoVolcanoToAltaInferno"))
        {
            if (CutscenesController.cus78 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus79 == 0 && CutscenesController.cus78 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoVolcanoToAltaInferno = true;
                FireFangTrigger1.despawn = false;
                FireFangTrigger2.despawn = false;
                FireFangTrigger3.despawn = false;
                FireFangTrigger4.despawn = false;
                MapIndex = 10;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoVolcanoToAltaInferno = true;
                FireFangTrigger1.despawn = false;
                FireFangTrigger2.despawn = false;
                FireFangTrigger3.despawn = false;
                FireFangTrigger4.despawn = false;
                MapIndex = 10;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
        if (collision.CompareTag("AltaInfernoToInfernoVolcano"))
        {
            MapController.AltaInfernoToInfernoVolcano = true;
            MapIndex = 8;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno volcano");
        }
        if (collision.CompareTag("InfernoIceToInsideIceCave"))
        {
            if (CutscenesController.cus68 == 0 && CutscenesController.cus67 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoIceToInsideIceCave = true;
                IceFangTrigger1.despawn = false;
                IceFangTrigger2.despawn = false;
                IceFangTrigger3.despawn = false;
                IceFangTrigger4.despawn = false;
                MapIndex = 9;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoIceToInsideIceCave = true;
                IceFangTrigger1.despawn = false;
                IceFangTrigger2.despawn = false;
                IceFangTrigger3.despawn = false;
                IceFangTrigger4.despawn = false;
                MapIndex = 9;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
        if (collision.CompareTag("InsideIceCaveToInfernoIce"))
        {
            MapController.InsideIceCaveToInfernoIce = true;
            BlueManaSlimeTrigger1.despawn = false;
            BlueManaSlimeTrigger2.despawn = false;
            BlueManaSlimeTrigger3.despawn = false;
            BlueManaSlimeTrigger4.despawn = false;
            MapIndex = 9;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno ice");
        }
        if (collision.CompareTag("InfernoIceToAltaInferno"))
        {
            if (CutscenesController.cus78 == 0)
            {
                show2.SetActive(true);
                show1.text = "You can go to this area yet!";
                Invoke("delay1", 2f);
            }
            else if (CutscenesController.cus79 == 0 && CutscenesController.cus78 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.InfernoIceToAltaInferno = true;
                IceFangTrigger1.despawn = false;
                IceFangTrigger2.despawn = false;
                IceFangTrigger3.despawn = false;
                IceFangTrigger4.despawn = false;
                MapIndex = 10;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.InfernoIceToAltaInferno = true;
                IceFangTrigger1.despawn = false;
                IceFangTrigger2.despawn = false;
                IceFangTrigger3.despawn = false;
                IceFangTrigger4.despawn = false;
                MapIndex = 10;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
        if (collision.CompareTag("AltaInfernoToInfernoIce"))
        {
            MapController.AltaInfernoToInfernoIce = true;
            MapIndex = 9;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno Ice");
        }
        if (collision.CompareTag("ZexelGateToZexelTemple"))
        {
            if (CutscenesController.cus93 == 0 && CutscenesController.cus92 == 1)
            {
                FadeInPanel.SetActive(true);
                MapController.ZexelGateToZexelTemple = true;
                MapIndex = 11;
                StartCoroutine(DelayChangeCutscense());
            }
            else
            {
                MapController.ZexelGateToZexelTemple = true;
                MapIndex = 11;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        if (collision.CompareTag("ZexelTempleToZexelGate"))
        {
            MapController.ZexelTempleToZexelGate = true;
            GhostTrigger1.despawn = false;
            GhostTrigger2.despawn = false;
            GhostTrigger3.despawn = false;
            GhostTrigger4.despawn = false;
            MapIndex = 4;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel gate");
        }

        if (collision.CompareTag("HealPoint"))
        {
            heal = true;
        }
        if (collision.CompareTag("TQZ"))
        {
            if (CutscenesController.cus6 == 0 && CutscenesController.cus4 == 1)
            {
                tqz = true;
                show2.SetActive(true);
                show1.text = "Press Space to commit the quest";
            }
        }
        if (collision.CompareTag("MQZ"))
        {
            if (CutscenesController.cus12 == 0 && CutscenesController.cus11 == 1)
            {
                mqz = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
        }
        if (collision.CompareTag("MWQZ"))
        {
            if (CutscenesController.cus82 == 0 && CutscenesController.cus81 == 1)
            {
                mwqz = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
        }
        if (collision.CompareTag("AlasaQZ"))
        {
            if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1)
            {
                alasaqz = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
            else if (CutscenesController.cus70 == 0 && CutscenesController.cus69 == 1)
            {
                alasaqz = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
        }
        if (collision.CompareTag("AsilaQZ"))
        {
            if (CutscenesController.cus71 == 0 && CutscenesController.cus70 == 1)
            {
                asilaqz = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
            else if (CutscenesController.cus77 == 0 && CutscenesController.cus76 == 1)
            {
                asilaqz = false;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
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
            if (CutscenesController.cus6 == 0 && CutscenesController.cus4 == 1)
            {
                tqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }
        if (collision.CompareTag("MQZ"))
        {
            if (CutscenesController.cus12 == 0 && CutscenesController.cus11 == 1)
            {
                mqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }
        if (collision.CompareTag("MWQZ"))
        {
            if (CutscenesController.cus82 == 0 && CutscenesController.cus81 == 1)
            {
                mwqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }
        if (collision.CompareTag("AlasaQZ"))
        {
            if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1)
            {
                alasaqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
            else if (CutscenesController.cus70 == 0 && CutscenesController.cus69 == 1)
            {
                alasaqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }
        if (collision.CompareTag("AsilaQZ"))
        {
            if (CutscenesController.cus71 == 0 && CutscenesController.cus70 == 1)
            {
                asilaqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
            else if (CutscenesController.cus77 == 0 && CutscenesController.cus76 == 1)
            {
                asilaqz = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Klener"))
        {
            if (CutscenesController.cus19 == 0 && CutscenesController.cus18 == 1)
            {
                klener = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
            else if (CutscenesController.cus22 == 0 && CutscenesController.cus21 == 1)
            {
                klener = true;
                show2.SetActive(false);
                show1.text = "Press Space to commit the quest";
            }
        }

        if (collision.gameObject.CompareTag("ManaGenerator"))
        {
            ManaGenerator = true;
        }

        if (collision.gameObject.CompareTag("FireManaGenerator"))
        {
            FireManaGenerator = true;
        }

        if (collision.gameObject.CompareTag("IceManaGenerator"))
        {
            IceManaGenerator = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Klener"))
        {
            if (CutscenesController.cus19 == 0 && CutscenesController.cus18 == 1)
            {
                klener = false;
                show2.SetActive(false);
                show1.text = "";
            }
            else if (CutscenesController.cus22 == 0 && CutscenesController.cus21 == 1)
            {
                klener = false;
                show2.SetActive(false);
                show1.text = "";
            }
        }

        if (collision.gameObject.CompareTag("ManaGenerator"))
        {
            ManaGenerator = false;
        }

        if (collision.gameObject.CompareTag("FireManaGenerator"))
        {
            FireManaGenerator = false;
        }

        if (collision.gameObject.CompareTag("IceManaGenerator"))
        {
            IceManaGenerator = false;
        }
    }

    void delay1()
    {
        show2.SetActive(false);
    }
    /*void delay2()
    {
        show4.SetActive(false);
    }*/

    IEnumerator DelayFadeOutOff()
    {
        yield return new WaitForSeconds(1.4f);
        FadeOutPanel.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        HubController.BusyHub = false;
    }

    IEnumerator DelayChangeCutscense()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Cutscenes");
    }
}
