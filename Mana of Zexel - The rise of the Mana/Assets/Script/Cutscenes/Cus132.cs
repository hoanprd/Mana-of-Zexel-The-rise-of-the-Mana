using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus132 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1;
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
                dia.text = "Barrier operation protect everyone in this town.";
            }
            else if (tang == 2)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggggg...";
            }
            else if (tang == 3)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "With this we can have some peace of mind.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! But we are not allowed to rest yet, there is still an inferno desert village in need of protection.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Father? Why are you going out like this, it's dangerous here!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I'm just a little worried, I don't want you to be in danger like this.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "... I've decided, if I stay weak, I won't be able to protect anyone.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "But you're my only relative, if something happens... we'll know what to do.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "I rarely see you worrying about me like this, after all, I have Vayne and Alia, we will definitely return safely.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "We're going to deal with some things now, don't worry.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Promise me you'll come back.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "It's too much for me to act like you're going to war. I promise to return to my father.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Good luck.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Uhm, let's go Vayne, Alia, we're starting to be the heroes of the world.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus132 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.OmnipotentBoundary -= 1;
                MapController.TavernToSaveRoom = false;
                MapController.WishingForestToZexelTown = true;
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
                dia.text = "Hoạt động đi kết giới hãy bảo vệ mọi người ở thị trấn này.";
            }
            else if (tang == 2)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggggg...";
            }
            else if (tang == 3)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Với thứ này chúng ta có thể yên tâm được phần nào rồi.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Nhưng chúng ta vẫn chưa được phép nghỉ ngơi đâu, vẫn còn ngôi làng inferno desert đang cần bảo vệ nữa.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cha? Sao cha lại ra ngoài như này, ở đây rất nguy hiểm đấy!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Cha chỉ hơi lo lắng, ta không muốn con phải gặp nguy hiểm như thế này.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "... Con đã quyết định rồi, nếu con cứ yếu đuối thì sẽ không thể bảo vệ ai được.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Nhưng con là người thân duy nhất của cha, nếu có chuyện gì xảy ra... thì ta biết làm sao.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Con ít khi thấy cha lo lắng cho con như này lắm, dù sao thì con đã có Vayne và Alia, nhất định bọn con sẽ an toàn trở về.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Giờ thì bọn con sẽ đi giải quyết một số thứ, cha cứ yên tâm.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hãy hứa với ta là con phải quay trở về.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Cha làm như con đi tham gia chiến tranh quá không bằng. Con hứa sẽ quay về với cha.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Chúc con may mắn.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Uhm, đi thôi Vayne, Alia, chúng ta đang bắt đầu trở thành anh hùng của thế giới rồi đấy.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus132 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.OmnipotentBoundary -= 1;
                MapController.TavernToSaveRoom = false;
                MapController.WishingForestToZexelTown = true;
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
        CutscenesController.cus132 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.OmnipotentBoundary -= 1;
        MapController.TavernToSaveRoom = false;
        MapController.WishingForestToZexelTown = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}