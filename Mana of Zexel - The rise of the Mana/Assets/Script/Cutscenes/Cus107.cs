using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus107 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, HeeriumVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        StartCoroutine(DelayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uncle Heerium! We came to ask you for a favor.";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Oh, it's Vayne and the others. Is there something important to you to find me?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We need to upgrade our weapons to become stronger.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hahaha... You've found the right person. It's easy to make a new weapon, but I don't have the materials.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Heerium";
                dia.text = "But if you bring me the ingredients, I'll make you new weapons.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay, just give me the list of ingredients so we can find them.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "Let's see, this material is quite far away, but I guarantee their quality is very good. List here Vayne!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "We already know, wait for good news from us.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus107 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToWeaponStore = false;
                MapController.WeaponStoreToZexelTown = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chú Heerium! Bọn cháu đến để nhờ chú một chuyện.";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Ồ là Vayne và mọi người đó à. Có chuyện gì quan trọng phải tìm đến ta à?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bọn cháu cần nâng cấp vũ khí để trở nên mạnh hơn.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hahaha... Các cháu tìm đúng người rồi đó. Được việc làm vũ khí mới đơn giản thôi nhưng nguyên liệu thì ta không có.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Heerium";
                dia.text = "Tuy nhiên nếu các cháu mang nguyên liệu về cho ta thì ta sẽ làm cho các cháu vũ khí mới.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được, chú cứ đưa cháu danh sách nguyên liệu để bọn cháu tìm cho.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "Để ta xem, nguyên liệu này ở khá xa nên nhưng ta đảm bảo chất lượng của chúng rất tốt. Danh sách đây Vayne!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bọn cháu đã rõ rồi, hãy chờ tin tốt từ tụi cháu.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus107 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToWeaponStore = false;
                MapController.WeaponStoreToZexelTown = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus107 = 1;
        ContainerController.LoadingOpen = true;
        MapController.ZexelTownToWeaponStore = false;
        MapController.WeaponStoreToZexelTown = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}