using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus127 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MeruVAR1;
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
                dia.text = "Everyone get out of here because there's going to be a big explosion!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Everyone's in the safe zone, Vayne! Let it explode.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "";
                dia.text = "Boooooooooooooooooooommmmmmmm...";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cough... Cough... All right!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Look, there's an underground spring. Success!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Great with this water, people don't have to worry anymore.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Great, now we just need to get diggers for a bigger geyser.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "Mrs. Meru! It's dangerous!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Meru";
                dia.text = "What is it? Why are you in such a hurry!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "The monster has entered the village! Everyone, please run away!";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's the inferno scorpion monsters, they want to invade this village?";
            }
            else if (tang == 13)
            {
                MeruVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like something happened to them, especially the earthquake just now that drove them crazy.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We have to help them, we can't stand by.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Be careful, Alia! That monster is more ferocious than usual, can't be subjective.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus127 = 1;
                ContainerController.UltraBom -= 2;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSInfernoScorpion 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mọi người mau tránh ra chỗ này vì sẽ có một vụ nổ lớn đấy!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mọi người đã trong vùng an toàn rồi Vayne! Cho phát nổ đi.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "";
                dia.text = "Boooooooooooooooooooommmmmmmm...";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cough... Cough... Được chưa thế!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nhìn kìa là mạch nước ngầm đã tuôn trào. Thành công rồi!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tuyệt vời với nguồn nước này mọi người không cần phải lo lắng nữa.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Tuyệt vời, giờ ta chỉ cần huy động người đào cho mạch nước lớn hơn là được.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "Bà Meru! Nguy thật rồi!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Meru";
                dia.text = "Là chuyện gì thế? Sao lại gấp gáp như này!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Con quái vật đã vào tận làng! Mọi người hãy mau chạy đi!";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Là tụi quái vật bọ cạp inferno, bọn chúng muốn xâm lược ngôi làng này ư?";
            }
            else if (tang == 13)
            {
                MeruVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ đã có chuyện gì xảy ra với bọn chúng, đặc biệt là trận động đất hồi nãy đã khiến chúng nổi điên.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng ta phải giúp họ thôi, không thể đứng nhìn được.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cẩn thận đấy Alia! Con quái vật đó hung dữ hơn bình thường đó, không được phép chủ quan đâu.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus127 = 1;
                ContainerController.UltraBom -= 2;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSInfernoScorpion 1");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 4)
        {
            cc.FXCutscenes(15);
        }
        else if (tang == 5)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 4)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 6)
        {
            cc.BGMCutscenes(2, false);
        }
        if (tang == 11)
        {
            cc.BGMCutscenes(5, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus127 = 1;
        ContainerController.UltraBom -= 2;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSInfernoScorpion 1");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}