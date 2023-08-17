using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus82 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ManaWaterVAL1, ManaWaterVAR1;
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
                dia.text = "Hey mana water, give this back pain medicine a try! I think it will work!";
            }
            else if (tang == 2)
            {
                ManaWaterVAR1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "Hmm, wait for me!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                ManaWaterVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "Hmmm... it's really effective, the pain from small to large is gradually disappearing... so comfortable... hahaha.";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey old man, don't forget your promise because it's so good!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana water";
                dia.text = "... I'm not a broken promise.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mana water";
                dia.text = "This is the bottle of purification water. Please use it carefully.";
            }
            else if (tang == 8)
            {
                ManaWaterVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like the first problem is solved already?";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, but I'm still curious about you mana water. After all, what is our destiny?";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "... I told you you will know in the future! I think you guys have more important things to do!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, then here we go!";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mana water";
                dia.text = "What's wrong red haired girl?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "No... nothing, just a little nostalgic for this place. I'm going!";
            }
            else if (tang == 15)
            {
                ManaWaterVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "It's pitiful for that girl, but she will realize her true worth.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus82 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.PurifyingWaterPick = 1;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này mana water, ông hãy xem thử thuốc đau lưng này đi! Tôi nghĩ sẽ có hiệu quả đó!";
            }
            else if (tang == 2)
            {
                ManaWaterVAR1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "Hừm, đợi ta tý nhé!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                ManaWaterVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "Hmmm... công nhận hiệu quả thật đấy, những cơn đau từ nhỏ đến lớn đang dần tan biến... thoải mái thật... hahaha.";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này ông già đừng quên lời hứa vì sướng quá đấy!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana water";
                dia.text = "... Ta không phải kẻ thất hứa đâu.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mana water";
                dia.text = "Đây chính là lọ nước thanh tẩy. Hãy sử dụng nó cẩn thận.";
            }
            else if (tang == 8)
            {
                ManaWaterVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ vấn đề đầu tiên đã được giải quyết rồi nhỉ?";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, nhưng tôi vẫn tò mò về ông đấy mana water. Rốt cuộc định mệnh của chúng tôi là gì?";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "... Ta đã bảo rồi các người sẽ biết trong tương lai thôi! Ta nghĩ các người có chuyện quan trọng hơn để làm đấy!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi, nếu vậy thì chúng tôi đi đây!";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mana water";
                dia.text = "Có chuyện gì sao cô bé tóc đỏ?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Không... không có gì, chỉ là hơi hoài niệm với nơi này thôi. Tôi đi đây!";
            }
            else if (tang == 15)
            {
                ManaWaterVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "Mana water";
                dia.text = "Thật đáng thương cho cô bé đó, nhưng cô ta sẽ nhận ra giá trị thật sự của bản thân thôi.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus82 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.PurifyingWaterPick = 1;
                SceneManager.LoadScene("Wishing forest");
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
        CutscenesController.cus82 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.PurifyingWaterPick = 1;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}