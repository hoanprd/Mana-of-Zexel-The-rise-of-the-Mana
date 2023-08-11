using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus52 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, ManaGuardianVAL1;
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
                ManaGuardianVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Salin";
                dia.text = "Very good, humans, Salin here I have to give up to you.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We don't want to fight, we just want to meet the mana gods.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Salin";
                dia.text = "I know what you're here for, but I just wanted to check if you're qualified to move on to the sacred world of mana.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Then we passed your test, right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Salin";
                dia.text = "Yes, I am the guardian of the world of man and mana, fate brought us together, I will open the gate to the world of mana.";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you very much.";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You say destiny? That means you knew we were coming here?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Salin";
                dia.text = "Yes, the gods say that a group of people will come to meet them and it is my duty to test the strength of that group.";
            }
            else if (tang == 9)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So do gods really exist?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Salin";
                dia.text = "Whether gods exist or not, go ahead and see with your own eyes the world where the gods of mana reside.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Salin";
                dia.text = "One more thing, I have a gift for you for defeating me which is my feather. Use it wisely.";
            }
            else if (tang == 12)
            {
                ManaGuardianVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Guardian feather +1";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus52 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.GuardianFeatherPick = 1;
                SceneManager.LoadScene("Mana gate");
            }
        }
        else
        {
            if (tang == 1)
            {
                ManaGuardianVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Salin";
                dia.text = "Khá thật đấy loài người, Salin ta đây phải chịu thua trước các ngươi.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi không muốn đánh nhau, chúng tôi chỉ muốn được gặp các vị thần mana.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Salin";
                dia.text = "Ta biết các ngươi đến đây để làm gì, chẳng qua ta muốn kiểm tra các ngươi có đủ tư cách để bước tiếp đến thế giới linh thiêng của mana hay không thôi.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy thì chúng tôi đã vượt qua bài kiểm tra của ngài rồi chứ gì?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Salin";
                dia.text = "Đúng thế, ta là hộ vệ canh giữ thế giới loài người và mana, định mệnh đã đưa chúng ta gặp nhau, ta sẽ mở cánh cổng đến với thế giới của mana.";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn ngài rất nhiều.";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ngài nói là định mệnh sao? Tức ngài biết trước chúng tôi sẽ đến đây?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Salin";
                dia.text = "Đúng thế, các vị thần nói rằng sẽ có một nhóm người đến để gặp họ và nhiệm vụ của ta là kiểm tra thực lực của nhóm người đó.";
            }
            else if (tang == 9)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy là các vị thần thật sự tồn tại ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Salin";
                dia.text = "Các vị thần có tồn tại hay không hãy bước tiếp để tận mắt chứng kiến thế giới nơi mà các vị thần mana đang ngự trị.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Salin";
                dia.text = "Một chuyện nữa, ta có một phần quà giành cho các người vì đã đánh bại ta đó chính là lông vũ của ta. Hãy sử dụng nó khôn ngoan.";
            }
            else if (tang == 12)
            {
                ManaGuardianVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Guardian feather +1";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus52 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.GuardianFeatherPick = 1;
                SceneManager.LoadScene("Mana gate");
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
        CutscenesController.cus52 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.GuardianFeatherPick = 1;
        SceneManager.LoadScene("Mana gate");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}