using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus55 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, ManaElfVAL1, ManaElfVAR1, ManaStoneVAR1, ManaLightVAR1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I can feel the mana increasing in abundance.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Welcome heroes, we mana gods are waiting for you!";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hero? Do we save the world or something?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Please introduce ourself my name is Vayne, and this is Maria, both of us are alchemists, the other is Alia.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana elf";
                dia.text = "I am the mana of the spirits, and the other two are the mana of stone and light. We are the descendants of the gods of mana. Nice to meet you guys.";
            }
            else if (tang == 7)
            {
                ManaElfVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Admittedly these gods are humble.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                ManaStoneVAR1.SetActive(true);
                NameTagText.text = "Mana stone";
                dia.text = "We respect you because you will have a very important responsibility later.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You mean we're going to save the world?";
            }
            else if (tang == 10)
            {
                ManaStoneVAR1.SetActive(false);
                ManaLightVAR1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Yes, it's only a matter of time now.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "We came here just to ask the mana gods how to open the gate of Zexel.";
            }
            else if (tang == 12)
            {
                ManaLightVAR1.SetActive(false);
                ManaElfVAR1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "We know you came here to ask about it but the question is, after Vayne finds your father, what will you do next?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "... This is...";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Pure selfishness wouldn't be worthy of a sacred place like this. Fate let us meet, which means something will happen in the future that affects the existence of mana and humans.";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Then can you tell us about the Zexel Gate and how to open it?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Of course, the Zexel portal was created by the alchemist Zexel almost a hundred years ago. The gate that was originally to protect the Temple of Zexel from the bad guys.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Avoid the bad guys? That means there's something inside the temple?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Yes, a hundred years ago, there was an elite mana like us named Sicxalon, back then mana and humans lived in harmony and so did Sicxalon.";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mana used to live with humans.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Mana elf";
                dia.text = "However, because of greed for humans taking advantage of our mana, Sicxalon didn't believe in it, but when they used Sicxalon's power to plot to monopolize mana, it made Sicxalon hate humans.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mana elf";
                dia.text = "And so Sicxalon broke out a war between mana and humans. As for us, we watched, because the humans only used us to cover their eyes, so we didn't stop Sicxalon from going to war with the humans.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Mana elf";
                dia.text = "However, Sicxalon objected to our mana not joining the war, so he fell and wanted to destroy us to monopolize his own power.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mana elf";
                dia.text = "At that time there was an alchemist named Zexel who defeated Sicxalon before he could destroy us, so mana and humans had a new agreement to live separately from then on. That's why we live in this independent world and don't allow humans to come here except for you.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "So after that battle the temple contained something of that war, right?";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Mana elf";
                dia.text = "That's right, since Sicxalon is a mana used by humans, his hatred is still there so he can't be reincarnated and his energy is too great to be destroyed. That's why Zexel has sealed his power and soul into the Zexel temple until now.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "I see, so it's the legendary story of the alchemist Zexel.";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Mana elf";
                dia.text = "To open the gate to the temple, you must have the two sources of mana energy that Zexel created as the key to the temple. Those two are the two energy cores currently stored in the land of inferno volcano and inferno ice. Let's collect them and give them to us.";
            }
            else if (tang == 29)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Inferno volcano and ice? Those two lands I have never been to.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like Heerium might know about those two places, Vayne because I've heard him sell ingredients sourced from those lands.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Mana elf";
                dia.text = "We've told what needs to be told, good luck on your quest to find those two cores.";
            }
            else if (tang == 32)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We thank you for the above information.";
            }
            else if (tang >= 33)
            {
                CutscenesController.cus55 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mình có thể cảm thấy lượng mana ngày càng dồi dào.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đó là...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Chào mừng các vị anh hùng, các vị thần mana chúng tôi đang đợi chờ mọi người đấy!";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Anh hùng ư? Chúng tôi có giải cứu thế giới hay gì à?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Xin được giới thiệu tôi tên là Vayne, còn đây là Maria, cả 2 chúng tôi là nhà giả kim, người còn lại là Alia.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Tôi là mana của các tinh linh, còn hai vị còn lại là mana của đá và ánh sáng. Chúng tôi là những hậu duệ đời sau của các vị thần mana. Rất vui được gặp các người.";
            }
            else if (tang == 7)
            {
                ManaElfVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận các vị thần này khiêm tốn thiệt.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                ManaStoneVAR1.SetActive(true);
                NameTagText.text = "Mana stone";
                dia.text = "Chúng tôi tôn trọng các người vì các người sẽ có một trọng trách rất quan trọng sau này.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ý ngài là chúng tôi sẽ giải cứu thế giới này sao?";
            }
            else if (tang == 10)
            {
                ManaStoneVAR1.SetActive(false);
                ManaLightVAR1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Đúng thế, vấn đề hiện giờ là thời gian thôi.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi đến đây chỉ để hỏi các vị thần mana cách để mở cánh cổng Zexel mà thôi.";
            }
            else if (tang == 12)
            {
                ManaLightVAR1.SetActive(false);
                ManaElfVAR1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Chúng tôi biết cậu đến đây để hỏi về việc đó nhưng vấn đề là sau khi Vayne tìm được cha của cậu rồi sẽ làm gì tiếp?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Chuyện này...";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Những sự ích kỷ đơn thuần sẽ không xứng đáng với nơi linh thiêng như này. Định mệnh cho chúng ta gặp nhau tức sẽ có chuyện gì đó sẽ xảy ra trong tương lai tới đây ảnh hưởng đến sự tồn tại của mana và cả con người.";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy thì các vị cho chúng tôi biết về cánh cổng Zexel cũng như cách mở cánh cổng ấy được chứ?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Được thôi, cánh cổng Zexel được tạo bởi nhà giả kim Zexel cách đây gần trăm năm trước. Cánh cổng vốn để bảo vệ đền thờ Zexel tránh khỏi những kẻ xấu.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tránh những kẻ xấu ư? Tức là bên trong đền thờ có thứ gì đó ư?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Đúng thế, một trăm năm trước, có một mana ưu tú như bọn ta tên là Sicxalon, khi ấy mana và con người sống với rất hòa thuận và Sicxalon cũng vậy.";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mana đã từng chung sống với con người ư.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Tuy nhiên vì lòng tham con người đã lợi dụng mana bọn ta, Sicxalon không tin vào việc ấy nhưng khi họ sử dụng sức mạnh của Sicxalon để âm mưu độc chiếm mana, điều ấy đã khiến Sicxalon căm hận con người.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Và thế là Sicxalon đã nổ ra cuộc chiến giữa mana và con người. Còn chúng ta thì lại đứng xem vì con người chỉ lợi dụng bọn ta một cách che mắt nên bọn ta cũng không ngăn cản việc Sicxalon gây chiến với loài người.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Tuy nhiên Sicxalon đã phản đối việc mana bọn ta không gia nhập cuộc chiến, nên hắn ta đã sa ngã và muốn tiêu diệt bọn ta để độc chiếm sức mạnh cho riêng hắn.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Khi ấy đã có một nhà giả kim tên là Zexel đã đánh bại Sicxalon trước khi hắn kịp tiêu diệt mana bọn ta, thế nên mana và con người đã có thỏa thuận mới là sẽ sống tách biệt nhau kể từ đó. Thế nên bọn ta sống ở thế giới độc lập như thế này và không cho phép con người đến đây ngoại trừ mấy người.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "Vậy sau trận chiến đó ngôi đền đã chứa đựng thứ gì đó của cuộc chiến đó đúng không?";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Đúng vậy, vì Sicxalon là một mana bị con người lợi dụng, lòng căm hận trong hắn vẫn còn nên không thể chuyển kiếp đi được cũng như nguồn năng lượng của hắn quá lớn để bị tiêu diệt. Cho nên Zexel đã phong ấn sức mạnh và linh hồn của hắn vào trong đền thờ Zexel cho đến tận nay.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Ra là thế, vậy đó là câu chuyện huyền thoại của nhà giả kim Zexel ư.";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Để mở được cánh cổng đi đến ngôi đền, các người phải có hai nguồn năng lượng mana mà Zexel đã từng tạo ra làm chìa khóa dẫn đến ngôi đền. Hai thứ đó là hai lõi năng lượng hiện đang cất giữ ở vùng đất inferno volcano và inferno ice. Hãy thu thập chúng rồi đưa chúng cho bọn ta.";
            }
            else if (tang == 29)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Inferno volcano và ice ư? Hai vùng đất đó tôi chưa từng đến.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hình như Heerium có thể biết đến hai nơi đó đấy Vayne vì chị từng nghe ông ấy bán các nguồn nguyên liệu có nguồn gốc từ những vùng đất đó thì phải.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Bọn ta đã kể những gì cần kể, chúc may mắn trên chặng đường tìm hai lõi năng lượng ấy.";
            }
            else if (tang == 32)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi cảm ơn với những thông tin trên. Được rồi mọi người chúng ta hãy quay về thị trấn thôi.";
            }
            else if (tang >= 33)
            {
                CutscenesController.cus55 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
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
        CutscenesController.cus55 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}