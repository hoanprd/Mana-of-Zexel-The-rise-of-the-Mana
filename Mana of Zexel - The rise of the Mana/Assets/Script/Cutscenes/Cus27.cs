using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus27 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, HeeriumVAL1;
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
                HeeriumVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Hahaha! Welcome to Heerium's blacksmith shop!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Heerium";
                dia.text = "Feel at home and tour around, this place offers all kinds of weapons from melee to long-range.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Heerium";
                dia.text = "Not only that, equipment like armor is also available. Do you guys find it interesting?";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Yes! Interesting too!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "The store doesn't look big, but that doesn't mean it's selling crap! The warriors who are and have visited this town are consulted and equipped with the best weapons to protect themselves against dangers such as monsters.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "Even the alchemist, I think you still need my weapon!";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Uncle Heerium! If so, do you sell weapons to alchemy?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Heerium";
                dia.text = "As long as you ask for it, it's fine.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So can you make a weapon for me? Like the iron shoes I wear are weapons!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "It's as easy as pie haha! What's up Vayne? If you want to reach the temple, you need powerful weapons!";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "If so, can you make me a weapon that is a staff that can accumulate mana?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Heerium";
                dia.text = "I can do it, but to make your weapons it has to be a bit more special and durable than your old weapons.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "If so, what is the source of the materials you need?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Heerium";
                dia.text = "Simply put, I only need iron, but for your weapons and Maria, you need more mana gems from the golems.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "I get it! Then we'll go find the source of the ingredients!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ok! See you again hahaha!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus27 = 1;
                ContainerController.LoadingOpen = true;
                MapController.WeaponStoreToZexelTown = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                HeeriumVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Hahaha! Chào mừng mọi người đến với tiệm rèn của Heerium!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hãy tự nhiên như ở nhà và tham quan xung quanh, nơi đây cung cấp đủ các loại vũ khí từ cận chiến đến tầm xa.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Heerium";
                dia.text = "Không chỉ thế các trang bị như áo giáp cũng có. Nào các cháu thấy thú vị chứ?";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Vâng! Cũng thú vị thật!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "Trông cửa tiệm không được lớn nhưng không có nghĩa là chỗ đây bán hàng dởm nhé! Các chiến đang và đã ghé qua thị trấn này đều được ta tư vấn và trang bị những vũ khí tốt nhất để phòng thân trước các mối nguy hiểm như quái vật.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "Kể cả nhà giả kim, ta nghĩ cháu vẫn cần vũ khí của chú đấy!";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Chú Heerium này! Nếu vậy chú có bán vũ khí cho giả kim thuật ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chỉ cần cháu yêu cầu như thế nào là được thôi.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy chú có thể làm thể loại vũ khí cho cháu được không? Như đôi giày sắt cháu đeo cũng là vũ khí đấy!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chuyện đó dễ như ăn bánh thôi haha! Sao nào Vayne? Nếu cháu muốn đến được ngôi đền thì phải cần những vũ khí mạnh mẽ đấy!";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy chú có thể làm cho cháu một loại vũ khí là một cây gậy có khả năng tích tụ mana được chứ?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chú làm được nhưng để làm các loại vũ khí cho các cháu thì phải đặc biệt một chút và bền hơn so với loại vũ khí cũ của các cháu.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy nguồn nguyên liệu chú cần là gì?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Heerium";
                dia.text = "Đơn giản thôi ta chỉ cần sắt, còn đối với vũ khí của cháu và Maria thì cần thêm mana gem từ tụi golems đấy.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cháu hiểu rồi! Vậy thì bọn cháu sẽ đi tìm nguồn nguyên liệu đây!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ok! Hẹn gặp lại hahaha!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus27 = 1;
                ContainerController.LoadingOpen = true;
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
        CutscenesController.cus27 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}