using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus110 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, ShanVAL1;
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
                dia.text = "Granted, we're much stronger than before!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's right, with this we can fight the magician Zane!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We must not be complacent, though.";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Shan";
                dia.text = "Hoh... phoo... Hoh... phoo...";
            }
            else if (tang == 5)
            {
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Is it Vayne? Is that Vayne?";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Is that person Shan? Why have you come this far?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Shan";
                dia.text = "Please help the two villages in inferno volcano and inferno ice go Vayne!";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's wrong, Shan? Calm down.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Shan";
                dia.text = "The monster inferno is back. It became more ferocious than before!";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "So that monster hasn't given up yet. All right, we'll give it a full blow this time.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Shan";
                dia.text = "Sorry to bother everyone.";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Don't worry, we're also excited about this new power and need some sandbags to fight!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus110 = 1;
                ContainerController.LoadingOpen = true;
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
                dia.text = "Công nhận chúng ta đã mạnh hơn trước rất nhiều!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đúng thế, điều này chúng ta có thể chiến đấu với tên ma pháp sư Zane rồi!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Dù vậy chúng ta không được phép chủ quan.";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Shan";
                dia.text = "Hộc... hộc... hộc...";
            }
            else if (tang == 5)
            {
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Là Vayne? Là vayne đó ư?";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Người đó là Shan ư? Sao cậu lại đi xa đến đây chi thế?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Shan";
                dia.text = "Xin hãy giúp hai ngôi làng ở inferno volcano và inferno ice đi Vayne!";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có chuyện gì thế Shan? Bình tĩnh tý nào.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Shan";
                dia.text = "Con quái vật inferno đã quay lại. Nó trở nên hung dữ hơn trước!";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy là con quái vật đó chưa bỏ cuộc sao. Được thôi lần này bọn tớ sẽ cho nó no đòn.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Shan";
                dia.text = "Xin lỗi vì phải làm phiền mọi người rồi.";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đừng lo, bọn tớ cũng đang hưng phấn với sức mạnh mới này đây và đang cần mấy bao cát để đánh đây!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus110 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 4)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus110 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}