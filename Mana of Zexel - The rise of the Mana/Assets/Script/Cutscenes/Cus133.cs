using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus133 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAL1, ManaGuardianVAL1, MeruVAR1;
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
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Ah! It's Vayne's group!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "What's wrong with you guys coming here?";
            }
            else if (tang == 3)
            {
                JescaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Well, we came to help the people in the village avoid the monsters.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "Monsters? They haven't come back here yet, but according to scouts outside the village, they might attack here again.";
            }
            else if (tang == 5)
            {
                MeruVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's why we came to protect this village!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "We'll create a barrier to stop these monsters. But we need permission from the village chief here.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Lucky that, you are free to do, I'm the village chief here.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, that's surprising if you believe in us.";
            }
            else if (tang == 9)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                MeruVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggg...";
            }
            else if (tang == 10)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Boundary completed.";
            }
            else if (tang == 11)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Thank you very much.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We also only come out of our hearts. We can't just stand by and watch others get hurt.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                MeruVAR1.SetActive(false);
                NameTagText.text = "Inferno desert villager";
                dia.text = "There are monsters in the sky!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's... mana guardian?";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Everyone calm down, it's not a monster and it won't harm you!";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                ManaGuardianVAL1.SetActive(true);
                NameTagText.text = "Salin";
                dia.text = "I finally found you guys.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You are Salin, why did you come here?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Salin";
                dia.text = "The mana gods want to meet you guys. Please come over there.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne...";
            }
            else if (tang == 20)
            {
                ManaGuardianVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm, we got it and we'll be right there.";
            }
            else if (tang == 21)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We're going Mrs. Meru, goodbye Jesca!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Goodbye and thank you for everything!";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus133 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.OmnipotentBoundary -= 1;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Ah! Là nhóm của anh Vayne!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Bọn cháu đến đây có chuyện gì ư?";
            }
            else if (tang == 3)
            {
                JescaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "À bọn cháu đến để giúp mọi người trong làng tránh khỏi bọn quái vật.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "Bọn quái vật ư? Bọn chúng vẫn chưa quay lại đây nhưng theo thám thính ngoài làng thì có thể chúng sẽ tấn công nơi đây một lần nữa.";
            }
            else if (tang == 5)
            {
                MeruVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chính vì thế bọn cháu đến đây để bảo vệ ngôi làng này!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bọn cháu sẽ tạo một kết giới để ngăn chặn lũ quái vật này. Nhưng bọn cháu cần sự cho phép của trưởng làng ở đây.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Tưởng gì, bọn cháu cứ thoải mái, ta chính là trưởng làng ở đây rồi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy ư, ngạc nhiên thật nếu vậy bà hãy tin ở chúng cháu.";
            }
            else if (tang == 9)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                MeruVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggg...";
            }
            else if (tang == 10)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Kết giới đã hoàn thành.";
            }
            else if (tang == 11)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Cảm ơn mấy cháu nhiều.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Bọn cháu cũng chỉ vì tấm lòng mà ra thôi. Chúng cháu không thể nhắm mắt đứng nhìn người khác bị hại được.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                MeruVAR1.SetActive(false);
                NameTagText.text = "Inferno desert villager";
                dia.text = "Có quái vật ở trên trời!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đó là... mana guardian?";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mọi người bình tĩnh đó không phải là quái vật cũng như sẽ không hại mọi người đâu!";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                ManaGuardianVAL1.SetActive(true);
                NameTagText.text = "Salin";
                dia.text = "Cuối cùng ta cũng tìm được mấy người.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Là Salin sao ông lại đến đây?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Mana guardian";
                dia.text = "Các vị thần mana muốn gặp mấy người đó. Xin mấy người hãy đến đấy.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne...";
            }
            else if (tang == 20)
            {
                ManaGuardianVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm, chúng tôi đã hiểu và sẽ đến đó ngay.";
            }
            else if (tang == 21)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng cháu đi đây bà Meru, tạm biệt nha Jesca!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Chào tạm biệt và cảm ơn anh chị vì tất cả!";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus133 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.OmnipotentBoundary -= 1;
                SceneManager.LoadScene("Inferno desert");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 9)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 10)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 13)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 14)
        {
            cc.BGMCutscenes(1, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus133 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.OmnipotentBoundary -= 1;
        SceneManager.LoadScene("Inferno desert");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}