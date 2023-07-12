using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus16 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, KlenerVAR1;
    public GameObject NameTag;
    private int tang = 0;

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
                dia.text = "Okay! This is enough to make a barrier to stop that golemn!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm counting on you.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Maria";
                dia.text = "You two wait for me a bit, but Alia, is your cauldron still okay?";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Everything is fine, I think Vayne is still good to use.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Well, then everything will be quick!";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I also have some of my mana preloaded.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Then thank you very much! Vayne";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Done! This is what helps us lock the golemn's feet for a while.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Just that simple? This thing looks like a cloth.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "This is not just a cloth, but a cloth filled with mana.";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I get it! Usually the golems will have a source of mana in them, if we combine the mana and resist them they can't advance.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right, this curtain is like a short barrier to prevent that golemn from going deep as well as a layer to protect the city from golemn.";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Come on show me how it works!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Okay let's go!";
            }
            else if (tang == 16)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It really worked!";
            }
            else if (tang == 18)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "The golemn looks more scared!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This is also just a temporary form, after a while this curtain will expire!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that case, we just need to make more.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "That's fine for now. We will find a way to solve it still the best.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm! I'll admit you're really good, I've never done these things before.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "The recipe is simple, you just need to transfer the mana into the cloth made from the extremely strong thread of this forest and combine them to create a net.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Maybe I'll try to stop this golem monster from entering town.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "If so, I'll ask you to do it.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anyway, the danger is over, we should go back to town, I still have something to investigate!";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Oh is that guy Vayne?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hmmm who is that?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Klener";
                dia.text = "I'm Mr. Lance town bodyguard named Klener. Here's Lance, I'm here to give an update on the golems who've been revolting lately.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Brother Klener doesn't have to worry because Vayne and Maria are done with it.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Klener";
                dia.text = "Maria too? Hello Maria, long time no see.";
            }
            else if (tang == 32)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It's okay, the iron golemn won't dare to go deep into the town.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Klener";
                dia.text = "Iron Golemn! How could such a dangerous monster be here.";
            }
            else if (tang == 34)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We'll find out later, now we should get back before the other monsters attack.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Klener";
                dia.text = "Well in that case I'll take you all back to town as a bodyguard.";
            }
            else if (tang == 36)
            {
                KlenerVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Klener is serious too!";
            }
            else if (tang >= 37)
            {
                CutscenesController.cus16 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToTavern = false;
                MapController.ZexelTownToWishingForest = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Được rồi! Nhiêu đây là đủ để chế tạo màng chắn để ngăn cản con golemn đó rồi!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nhờ chị vậy.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Maria";
                dia.text = "Hai đứa đợi chị một chút, à mà Alia, cái vạc của chị vẫn không sao chứ?";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tất cả đều ổn đó chị, em thấy Vayne sử dụng vẫn tốt.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Vậy ư, nếu vậy mọi thứ sẽ nhanh thôi!";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em cũng đã nạp sẵn một phần mana của em rồi.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Vậy thì cảm ơn em nhiều!";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Xong rồi! Đây chính thứ giúp chúng ta nhốt chân con golemn lại một thời gian.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chỉ đơn giản vậy thôi ư? Trông thứ này như một tấm vải vậy.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Đây không đơn thuần là tấm vải đâu mà là tấm vải chứa đầy ma lực.";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em hiểu rồi! Thường tụi golemn sẽ có một nguồn ma lực trong người chúng, nếu ta cộng hưởng nguồn ma lực và kháng chúng ra thì chúng không thể tiến tới được.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế, tấm màn này như lá chắn ngắn chặn con golemn đó tiến sâu cũng như là lớp bảo vệ thành phố khỏi golemn.";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nào nào hãy cho e xem nó hoạt động như thế nào đi!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Được rồi chúng ta đi thôi!";
            }
            else if (tang == 16)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nó hiệu nghiệm thật rồi!";
            }
            else if (tang == 18)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Con golemn trông sợ hãi hơn rồi kìa!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đây cũng chỉ là hình thức tạm bợ thôi, một thời gian sau tấm màn này sẽ hết hiệu lực thôi!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy chúng ta chỉ cần chế tạo thêm là được.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "Tạm thời vậy là được rồi. Chúng ta sẽ tìm cách giải quyết nó vẫn là tốt nhất.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm! Công nhận chị giỏi thật, em chưa từng làm những thứ này bao giờ.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "Công thức cũng đơn giản thôi em chỉ cần chuyền mana vào tấm vải làm từ sợi chỉ vô cùng chắc chắn của khu rừng này là được rồi và kết hợp chúng để tạo ra một mạng lưới.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có lẻ em sẽ làm thử để ngăn chặn quái vật như golem này tiến vào thị trấn.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy thì chị nhờ em vậy.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Dù sao thì mối nguy hiểm đã qua, chúng ta nên quay về thị trấn thôi, em vẫn còn thứ để điều tra!";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Ồ cậu kia là Vayne à?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hửm ai thế?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Klener";
                dia.text = "Tôi là vệ sĩ thị trấn của Mr. Lance đây, tôi đến để cập nhật tình hình về tụi golemn dạo gần đây nổi loạn.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Anh Klener không cần phải lo vì Vayne và chị Maria đã xử lý xong rồi.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Klener";
                dia.text = "Chị Maria nữa ư? Em chào chị lâu rồi vẫn chưa gặp.";
            }
            else if (tang == 32)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Không sao đâu, con golemn sắt kia sẽ không dám tiến sâu đến thị trấn nữa đâu.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Klener";
                dia.text = "Golemn sắt! Làm thế nào mà một con quái vật nguy hiểm như thế lại ở đây.";
            }
            else if (tang == 34)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chuyện đó chúng ta sẽ tìm hiểu sau, giờ thì chúng ta nên quay lại trước khi tụi quái vật nào khác tấn công.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Klener";
                dia.text = "Vâng nếu vậy tôi sẽ tiễn mọi người về thị trấn với tư cách là một vệ sĩ.";
            }
            else if (tang == 36)
            {
                KlenerVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Anh Klener cũng nghiêm túc phết nhỉ!";
            }
            else if (tang >= 37)
            {
                CutscenesController.cus16 = 1;
                ContainerController.LoadingOpen = true;
                MapController.ZexelTownToTavern = false;
                MapController.ZexelTownToWishingForest = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 17)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 23)
        {
            cc.BGMCutscenes(2, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus16 = 1;
        ContainerController.LoadingOpen = true;
        MapController.ZexelTownToTavern = false;
        MapController.ZexelTownToWishingForest = true;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(5, false);
    }
}