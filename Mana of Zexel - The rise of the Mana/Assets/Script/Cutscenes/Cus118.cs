using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus118 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
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
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Woman)";
                dia.text = "You must be Vayne right? We have been informed by Mr. Asila that we will be helping to restore the damage to the village.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes that's right! Is there anything I can help you with? Please let me know!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Currently I lost my husband when the inferno beast attacked the village. I ask you to help me find him.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Do you remember the last time you two met before being separated?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Last time we had to run south to avoid the attack. But then he suddenly disappeared.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "In the south? Could it be that her husband is lost in the nearby ice cave?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "I'm not sure because I haven't searched the ice cave yet.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, we'll help you find your husband. Please wait for good news from us!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Yes, thank you very much!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus118 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Woman)";
                dia.text = "Cậu chắc hẳn là Vayne đúng không? Chúng tôi đã được ngài Asila báo rằng sẽ được cậu giúp đỡ phục hồi thiệt hại ngôi làng.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vâng đúng thế! Có chuyện gì mà tôi có thể giúp cô không? Xin hãy cho tôi biết!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Hiện tại tôi đã lạc mất chồng của tôi khi quái vật inferno beast tấn công ngôi làng. Tôi mong cậu hãy giúp tôi tìm ông ấy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cô có nhớ gì về lần cuối hai người gặp trước khi bị tách ra không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Lần trước đó chúng tôi đã phải chạy về phía nam để tránh cuộc tấn công. Nhưng sau đó ông ấy lại biến mất một cách ngạc nhiên.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ở phía nam ư? Có khi nào chồng cô đang lạc ở trong hang băng gần đó chăng?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Tôi không chắc nữa vì tôi vẫn chưa tìm kiếm trong hang băng.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi, chúng tôi sẽ giúp cô tìm kiếm chồng cô xin hãy chờ tin tốt từ bọn tôi nhé!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Vâng, cảm ơn các người rất nhiều!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus118 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
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
        CutscenesController.cus118 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}