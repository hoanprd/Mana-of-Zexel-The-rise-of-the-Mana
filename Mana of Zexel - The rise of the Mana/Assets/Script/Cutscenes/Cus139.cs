using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus139 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va0, va1, va2, va3;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
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
                NameTagText.text = "Sicxalon";
                dia.text = "Grrruuuhhhhhhhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "This monster is terrible if you destroy it, it will all explode.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "What should we do, it has weakened a lot.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "If we don't destroy it, there's only a way to seal it like my mother did.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Wait, I have an idea.";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "What are you going to do, Vayne? Don't go near that monster!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "I will reincarnate it, it will definitely help the next generation.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Now submit to me Hyaaaaaaa!!!";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Sengggggggggggggggg...";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That's...";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "The soul of Sicxalon. I have succeeded!";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Well done, Vayne!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "With this, just give the gods mana and they can do the rest.";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Bastard, how dare you... I can't lose like that.";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Shut up, you're no longer capable of fighting, give up, we're lucky we haven't hit you yet.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Zane";
                dia.text = "Pity me... hahahahaha I'll let you all go to hell with me!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Zane";
                dia.text = "I'll blow them all up!!!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Stop it Zane!";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mana shield!";
            }
            else if (tang == 21)
            {
                ZaneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Sister Maria! What are you thinking of doing!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne, Alia both of you can't die, you both have a bright future, get out of here quickly.";
            }
            else if (tang == 23)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "No... can't leave you alone!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Our journey isn't long but I've come to realize some things... some things called sacrifices are required to protect those we love.";
            }
            else if (tang == 25)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Sister Mariaa!!!";
            }
            else if (tang == 26)
            {
                AliaVAL1.SetActive(false);
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "You wants to die with me...";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right! Don't try to touch my two friends.";
            }
            else if (tang == 28)
            {
                ZaneVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'll take you out!";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Maria";
                dia.text = "Mana shield pushes Vayne away!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ahhh... Sister Maria!";
            }
            else if (tang == 31)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmmmm...";
            }
            else if (tang == 32)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "No! The wall has fallen...";
            }
            else if (tang == 33)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Damn... we have to get out Alia...";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Alia";
                dia.text = "No... can't leave Maria like that...";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Vayne";
                dia.text = "We have to get out quickly or we'll be buried here... we can't let her make a meaningless sacrifice! Hic...";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Alia";
                dia.text = "Hic... hic... Impossible...";
            }
            else if (tang == 37)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(I'm sorry and thank you Maria...)";
            }
            else if (tang == 38)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hmm... looks like I can close my eyes peacefully, right?";
            }
            else if (tang == 39)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            }
            else if (tang == 40)
            {
                NameTagText.text = "Maria";
                dia.text = "(Father, I'm sorry I didn't keep my promise. Goodbye everyone.)";
            }
            else if (tang == 41)
            {
                va1.SetActive(false);
                va0.SetActive(true);
                MariaVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Bbbbbbbbbbbbbbbbbbbbbbbbooooooooooooooooooooooooooooommmmmmmmmmmmmmmmmmmmmmmmmmm...";
            }
            else if (tang == 42)
            {
                va0.SetActive(false);
                va3.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 43)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hoh phoh... Hoh phoh... Alia! Alia where are you!";
            }
            else if (tang == 44)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Huh... Vayne! I'm ok!";
            }
            else if (tang == 45)
            {
                NameTagText.text = "Vayne";
                dia.text = "Luckily, we're all safe!";
            }
            else if (tang == 46)
            {
                NameTagText.text = "Alia";
                dia.text = "Sister Maria! She...";
            }
            else if (tang == 47)
            {
                NameTagText.text = "Vayne";
                dia.text = "I can't feel any trace of her anymore... she saved us...";
            }
            else if (tang == 48)
            {
                NameTagText.text = "Alia";
                dia.text = "Hic... no way...";
            }
            else if (tang == 49)
            {
                NameTagText.text = "Vayne";
                dia.text = "Don't worry Maria, we survived. Thank you, Maria!";
            }
            else if (tang >= 50)
            {
                CutscenesController.cus139 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTempleToZexelGate = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Sicxalon";
                dia.text = "Grrruuuhhhhhhhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Con quái vật này đúng là kinh khủng nếu tiêu diệt nó thì tất cả sẽ bị nổ tung mất.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta nên làm gì đây, nó đã yếu đi rất nhiều.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nếu chúng ta không tiêu diệt nó thì chỉ còn có cách phong ấn như mà mẹ tớ đã làm.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Khoan đã, tớ có ý này.";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em tính làm gì thế Vayne? Đừng đến gần con quái vật đó!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Em sẽ hóa kiếp nó, nhất định nó sẽ giúp ích cho thế hệ sau.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nào hãy quy phục trước ta Hyaaaaaaa!!!";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Sengggggggggggggggg...";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đó là...";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Linh hồn của Sicxalon. Mình đã thành công rồi!";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hay lắm Vayne!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Với thứ này chỉ cần đưa cho các vị thần mana là họ có thể làm nốt phần còn lại rồi.";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Tên khốn, sao ngươi dám... ta không thể thua như vậy được.";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Im đi, ngươi không còn khả năng chiến đấu nữa đâu, hãy bỏ cuộc đi, bọn ta chưa ra tay với ngươi là may lắm rồi.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Zane";
                dia.text = "Thương hại ta à... hahahahaha ta sẽ cho các ngươi về chầu trời cùng ta!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Zane";
                dia.text = "Ta sẽ nổ tung hết tất cả!!!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mau dừng lại Zane!";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Lá chắn mana!";
            }
            else if (tang == 21)
            {
                ZaneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chị Maria! Chị tính làm gì thế!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne, Alia cả hai đứa không được chết, hai đứa còn một tương lai tươi sáng, mau ra khỏi đây đi.";
            }
            else if (tang == 23)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không... không thể để chị lại được!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Cuộc hành trình của chúng ta tuy không dài nhưng chị đã nhận ra một số thứ... một số thứ gọi là sự hy sinh là điều phải bắt buộc để bảo vệ những người mà ta yêu thương.";
            }
            else if (tang == 25)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Chị Mariaaa!!!";
            }
            else if (tang == 26)
            {
                AliaVAL1.SetActive(false);
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Con khốn này muốn chết chung với ta à...";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế! Đừng hòng chạm vào hai người bạn của ta.";
            }
            else if (tang == 28)
            {
                ZaneVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em sẽ đưa chị ra ngoài!";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Maria";
                dia.text = "Mana shield đẩy Vayne ra!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ahhh... Chị Maria!";
            }
            else if (tang == 31)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmmmm...";
            }
            else if (tang == 32)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Không! Bức tường đã sụp đổ...";
            }
            else if (tang == 33)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chết tiệt... chúng ta phải ra ngoài thôi Alia...";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Alia";
                dia.text = "Không... không thể để chị Maria như thế được...";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta phải ra ngoài mau nếu không sẽ bị chôn vùi ở đây mất... chúng ta không thể để chị ấy hy sinh vô nghĩa được! Hic...";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Alia";
                dia.text = "Hic... hic... Không thể nào...";
            }
            else if (tang == 37)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Em xin lỗi và cảm ơn chị Maria...)";
            }
            else if (tang == 38)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hừm... có vẻ như mình có thể nhắm mắt một cách thanh thản rồi nhỉ?";
            }
            else if (tang == 39)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Khôngggggggggggggggggggggggg!!!";
            }
            else if (tang == 40)
            {
                NameTagText.text = "Maria";
                dia.text = "(Cha, con xin lỗi vì đã không giữ được lời hứa. Tạm biệt mọi người.)";
            }
            else if (tang == 41)
            {
                va1.SetActive(false);
                va0.SetActive(true);
                MariaVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Bbbbbbbbbbbbbbbbbbbbbbbbooooooooooooooooooooooooooooommmmmmmmmmmmmmmmmmmmmmmmmmm...";
            }
            else if (tang == 42)
            {
                va0.SetActive(false);
                va3.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 43)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hộc... hộc... Alia! Alia em ở đâu!";
            }
            else if (tang == 44)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hộc... Vayne! Em vẫn ổn!";
            }
            else if (tang == 45)
            {
                NameTagText.text = "Vayne";
                dia.text = "May quá, chúng ta đã bình an vô sự!";
            }
            else if (tang == 46)
            {
                NameTagText.text = "Alia";
                dia.text = "Chị Maria! Chị ấy...";
            }
            else if (tang == 47)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anh không còn cảm nhận được bất kỳ dấu tích gì của chị ấy nữa... chị ấy đã cứu chúng ta...";
            }
            else if (tang == 48)
            {
                NameTagText.text = "Alia";
                dia.text = "Hic... không thể nào...";
            }
            else if (tang == 49)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chị yên tâm đi Maria, bọn em đã sống sót. Cảm ơn chị Maria!";
            }
            else if (tang >= 50)
            {
                CutscenesController.cus139 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTempleToZexelGate = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 41)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 41)
        {
            cc.BGMCutscenes(6, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus139 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel gate");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(5, false);
    }
}