using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus11 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

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
                dia.text = "Look, Alia! There is a house in the middle of this secluded forest.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Do you think that is the old house of Mr. Lance?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's possible.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Knock knock, is anyone at home?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hey wait Alia! Don't randomly knock on people's doors like that!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Relax Vayne, Maria is not angry about this.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "How are you sure this house belongs to Maria!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "Hey, what are you two doing in front of my house? Oh, is that Alia?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Sister Maria! Long time no see!";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alright, let's talk in the house. In addition to this should not be outside for too long.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Is this guy your boyfriend, Alia?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "No, it's not... This is...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Okay, just kidding! No need to stress. Now let's get to the main story.";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hi Maria, my name is Vayne, an alchemist from Zorth. I need you to check the books of someone who has been to Mr. Lance 1 year ago.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Is that person important to you?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes! That's my father, he stopped contacting my mother and me for more than a year.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "I have come here to find information about my father, please help. Book of Mr. Lance 1 year ago were recorded and stored in this house.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Oh I get it, okay! I'll rummage through those books for you, but on one condition.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Conditions?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Maria";
                dia.text = "I'm very busy, while I'm going through the books, will you get me some mana gems?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, but where can you find those here?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "The golems in this forest had a fair amount of mana. So if you cut them down, there will be a lot of mana gems.";
            }
            else if (tang == 23)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Then it's fine for the two of us to just kill those golems.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "They can be found in the southern part of this forest, be careful, they are very strong!";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus11 = 1;
                ContainerController.LoadingOpen = true;
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
                dia.text = "Nhìn kìa Alia! Đằng kia có một ngôi nhà ở giữa khu rừng này.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Do you think that is the old house of Mr. Lance? Cậu có nghĩ là ngôi nhà cũ của chú Lance không?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cũng có thể lắm";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Cốc cốc, có ai ở nhà không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đừng có tự tiện gõ cửa nhà người khác như thế chứ!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Relax Vayne, Maria is not angry about this. Bình tĩnh đi Vayne, chị Maria sẽ không giận vì chuyện đó đâu.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Sao cậu chắc ngôi nhà này thuộc về chị ấy!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "Này, cả hau đang làm gì trước nhà của tôi vậy?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Chị Maria! Lâu rồi không gặp ạ!";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Được rồi, vào trong nhà nói chuyện đi. Chúng ta không nên ở ngoài này quá lâu.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Cậu trai này đây có phải là bạn trai của Alia không thế?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Không, không phải... đây là...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị chỉ đùa thôi! Không cần phải căng thẳng thế đâu. Chúng ta hãy vô vấn đề chính đi.";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chào chị Maria, em tên là Vayne là một nhà giả kim thuật đến từ Zorth. Em cần chị kiểm tra sổ sách ghi chép của chú Lance về các nhà phiêu lưu đã ghé qua thị trấn này một năm trước.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Người em cần tìm rất quan trọng ư?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy, đó chính là cha của em, ông ấy đã mất liên lạc với gia đình em hơn một năm nay.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em đến đây để tìm tung tích của ông ấy, mong chị giúp em. Cuốn sổ một năm trước của chsu Lance chắc hẳn đã ghi chép gì ấy về ông ấy có thể đang được giữ trong ngôi nhà này";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Được rồi, chị đã hiểu tình hình! Chị sẽ truy tìm cuốn sổ đó cho em nhưng với một điều kiện.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Điều kiện ư?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị hiện tại đang rất bận trong khi chị tìm cuốn sổ đó, em sẽ thay chị tìm kiếm các ngọc năng lượng?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng, nhưng em sẽ tìm chúng ở đâu mới được?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Bọn golem ở trong khu rừng nay chưa một lượng lớn năng lượng. Nếu em hạ được bọn chúng thì sẽ nhặt được ngọc năng lượng.";
            }
            else if (tang == 23)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy thì ổn thôi, hau bọn em chỉ cần hạ bọn golem đó là được chứ gì?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Chúng có thể tìm thấy ở phía nam khu rừng đấy, hãy cẩn thận vì chúng rất mạnh đấy!";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus11 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus11 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}
