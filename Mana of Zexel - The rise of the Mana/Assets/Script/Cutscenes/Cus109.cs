using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus109 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, MariaVAR1, OrinaVAR1;
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
                dia.text = "Hey Orina! Are you here?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Huh? Hey... hey... why don't you guys knock before entering?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Even we knock on the door, you won't open it.";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hmm? Something Orina... how could she...";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's dark magic... Orina you're...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Boring! I was trying to change my appearance a bit with dark magic but I was interrupted by you guys.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Why are you hiding the fact that you're a magician?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "I simply don't want to get in trouble. How many people understand...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "What happened Orina... surely your past has kept you hidden until now?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "It happened a long time ago... from the time of the war mages. Everyone was afraid of magicians, so they sought to destroy people like me.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Orina";
                dia.text = "That's why my husband had to die, and my children no longer trust anyone, so they left alone and left me alone.";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's cruel... you have to endure such solitude all the time... it seems we're a little too wordy for you...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Orina";
                dia.text = "It's okay, for someone who is over a hundred years old, looking at you guys makes me feel like my past self.";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Are you over 100 years old? Why is she still so young?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "Dark magic can do anything, even immortality.";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "But you don't seem to have any malice towards people.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "I just want to live peacefully. But it seems my son doesn't want that.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Your son? Who is that?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "The one who killed your father and gave Alia a fatal wound. It was none other than Zane.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "I met and talked to her almost a year ago, he has lost her humanity, I can't teach her anymore. So I really hope someone eats its evil plots to monopolize the world.";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "What an ironic fate...";
            }
            else if (tang == 23)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Orina, we're going to beat Zane and bring him back here to make amends. I won't leave him alone either.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Can you guys do that? If so, we'll have to ask for your help.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Orina";
                dia.text = "Oh, one more thing, I have something for you, Vayne.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is this an alchemy recipe?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Orina";
                dia.text = "That's right, this is a recipe for making powerful items that use a lot of mana energy.";
            }
            else if (tang == 28)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "How did you get these things Orina?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Orina";
                dia.text = "You'll know when the time comes. Maria, I can't say that.";
            }
            else if (tang == 30)
            {
                MariaVAL1.SetActive(false);
                OrinaVAR1.SetActive(false);
                NameTagText.text = "Villager";
                dia.text = "Danger, danger! Everyone go back to town, the iron golemn monster is coming!";
            }
            else if (tang == 31)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Don't tell me the iron golemn we stopped earlier broke Maria's barrier?";
            }
            else if (tang == 32)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like we know who we should try the new powers we have, Vayne.";
            }
            else if (tang == 33)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay, let's give that iron golemn a fight.";
            }
            else if (tang >= 34)
            {
                CutscenesController.cus109 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này Orina! Cô có ở đây chứ?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Hử? Này... này... sao mấy người không gõ cửa trước khi vào vậy?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bọn tôi có gõ cửa thì cô cũng có chịu mở đâu.";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hửm? Thứ gì đấy Orina... tại sao cô có thể...";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đó là ma thuật hắc ám... Orina cô là...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Chán thật! Tôi đang cố thay đổi ngoại hình một tý bằng ma thuật hắc ám mà bị mấy người phá đám.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tại sao cô lại giấu việc bản thân là một ma pháp sư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Đơn giản là không muốn gặp rắc rối thôi. Mấy người sao hiểu được...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đã có chuyện gì xảy ra thế Orina... chắc hẳn quá khứ của cô đã khiến cô phải che giấu đến tận giờ ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "Chuyện đã xảy ra lâu rồi... từ thời pháp sư đại chiến. Mọi người đều sợ hãi các ma pháp sư, nên họ đã tìm cách tiêu diệt những người như tôi.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Orina";
                dia.text = "Chính vì thế chồng tôi phải bỏ mạng, còn con của tôi không còn tin tưởng ai nên đã một mình bỏ đi và để tôi lại một mình.";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Thật tàn nhẫn... cô phải chịu đựng sự cô độc như vậy suốt ư... có vẻ chúng tôi có hơi quá lời với cô...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Orina";
                dia.text = "Không sao đâu, đối với người sống hơn trăm tuổi khi nhìn các cô cậu khiến tôi cũng có cảm giác như bản thân mình ở quá khứ.";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cô đã hơn 100 tuổi rồi ư? Tại sao cô vẫn còn trẻ thế.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "Ma thuật hắc ám có thể làm được mọi thứ đấy, kể cả việc trường sinh.";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nhưng cô có vẻ không có ác ý gì với mọi người.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "Ta chỉ muốn sống một cách yên bình thôi. Nhưng có vẻ con trai ta lại không muốn vậy.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Con trai của cô ư? Đó là ai?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Là người đã giết cha cậu cũng như cho Alia một vết thương chí mạng đấy. Không ai khác đó là Zane.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Ta đã gặp và nói chuyện với nó cách đây gần một năm, nó đã không còn nhân tính nữa, ta không thể dạy dỗ nó được nữa. Cho nên ta rất mong có ai đó hãy ăn những âm mưu xấu xa của nó là độc chiếm cả thế giới.";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Số phận thật trớ truê...";
            }
            else if (tang == 23)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Orina, chúng tôi sẽ cho tên Zane một trận rồi vác hắn về đây để chuộc lỗi. Tôi cũng không để yên cho hắn ta đâu.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Mấy người có thể làm được chuyện đó ư? Nếu vậy ta phải nhờ các người giúp rồi.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Orina";
                dia.text = "À một thứ nữa, tôi có thứ này đưa cho cậu đấy Vayne.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cái này là công thức giả kim?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Orina";
                dia.text = "Đúng thế, đây là công thức chế tạo những vật phẩm mạnh mẽ sử dụng rất nhiều năng lượng mana.";
            }
            else if (tang == 28)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Làm sao mà cô có những thứ này thế Orina?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Orina";
                dia.text = "Cô sẽ biết khi thời điểm đến thôi Maria, tôi không thể nói rõ điều đó được.";
            }
            else if (tang == 30)
            {
                MariaVAL1.SetActive(false);
                OrinaVAR1.SetActive(false);
                NameTagText.text = "Villager";
                dia.text = "Nguy hiểm, nguy hiểm! Tất cả mọi người hãy vào lại thị trấn, quái vật golemn sắt sắp đến đây rồi!";
            }
            else if (tang == 31)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đừng nói là con golemn sắt mà chúng ta cản trước đó đã phá vỡ màn chắc của Maria?";
            }
            else if (tang == 32)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ chúng ta biết nên thử những sức mạnh mới mà chúng ta có được vào ai rồi đó Vayne.";
            }
            else if (tang == 33)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được thôi, chúng ta hãy cho con golemn sắt đó một trận nào.";
            }
            else if (tang >= 34)
            {
                CutscenesController.cus109 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 5)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 8)
        {
            cc.BGMCutscenes(6, false);
        }
        if (tang == 23)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 30)
        {
            cc.BGMCutscenes(4, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus109 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}