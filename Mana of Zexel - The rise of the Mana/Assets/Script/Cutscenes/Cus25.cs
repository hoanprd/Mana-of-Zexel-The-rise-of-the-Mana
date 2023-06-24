using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus25 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAR1;
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
                dia.text = "Just as simple as this?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks good too! It looks small, but that's enough to destroy a mid-range golem!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "It too dangerous!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Calm down, you can make it play if it's amplified by me. That is, before throwing, transfer the amount of mana to compress them and boom.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Phew! By the way, did you learn all these alchemy knowledge on your own?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right! More precisely, I learned from a book when I was a child.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Can't believe you've been inspired by alchemy since childhood? I'm too old to even get into alchemy!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Also nothing! If I had had a talent from a young age, things would have been different, my mother would have...";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Is something wrong with your parents?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "No... Nothing! It was just that she was too weak back then.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Maria, don't you use alchemy to help everyone in the village because of something you're obsessed with?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "... Klener told you already?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "No, Klener doesn't know anything about you.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "It's really hard to hide, when I was young, there was a pandemic in town! At that time, my mother was in the medical room.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "She was very busy taking care of the patients, and it was because of this that my mother was infected.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "I couldn't stand still, so I found a way to neutralize the disease, so that's when I read the book on alchemy, which I hoped was a miracle.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = "It's ironic that neither my father nor the people in the village believe in alchemy because I just do something that no one else thinks of.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Unbelievable. Even so, are you continuing to study alchemy?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "Yes, but my mother was… she had reached her limit and everything had come to an end. At that time, my father and sister were just dumbfounded...";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, I get it and maybe there's a misunderstanding about you. I'm sorry!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "I couldn't protect anyone and everyone didn't believe me!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Okay it's over! You did a great job to stop the iron golem out there or else the town wouldn't be so quiet right now!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Not only that, you taught me about alchemy. Someone like you is very respectful!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne... I get it! Looks like fate brought the two of us together if that's the case I've made up my mind!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "I will accompany you to find your father's whereabouts.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's great, thank you and look forward to teaching!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Looks like you've changed from before! Maybe being accompanied by a good person like you!";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe! If nothing else, we're ready to go!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus25 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.Bom -= 1;
                SceneManager.LoadScene("Save room");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chỉ đơn giản thế này thôi ư?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Trông cũng ổn đấy! Nhìn nhỏ vậy chứ nhiêu đó đủ tiêu diệt một con golem tầm trung đó!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hể nguy hiểm quá!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Bình tĩnh đi, em có thể khiến nó phát nếu nó được e khuếch đại mana của mình vào. Tức trước khi ném hãy truyền lượng mana để nén chúng và bùm.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em cảm ơn! À mà những kiến thức giả kim này chị tự học hết ư?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế! Chính xác hơn chị học được từ một cuốn sách lúc chị còn nhỏ.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không thể tin được chị có cảm hứng giả kim thuật từ nhỏ rồi ư? Em thì khá lớn mới bắt đầu đụng đến giả kim thuật ấy!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Cũng không có gì! Nếu như chị có năng khiếu từ nhỏ thì mọi chuyện đã khác rồi, mẹ của chị đã...";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Có chuyện gì với cha mẹ của chị sao?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Không... Không có gì! Chẳng qua là chị đã quá yếu kém khi ấy thôi.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Chị Maria, có phải chị không dùng giả kim thuật để giúp mọi người trong làng cũng vì chị bị ám ảnh bởi điều gì ư?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "... Klener nói với em rồi ư?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không, Klener không biết gì về chị cả.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng là khó giấu thật, lúc chị còn nhỏ thì gặp phải một đại dịch ở thị trấn! Lúc ấy mẹ chị là người thuộc phòng y tế.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Hai người họ rất bận rộn để chăm sóc các bệnh nhân, cũng chính điều này mẹ chị đã bị nhiễm bệnh.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị không thể đứng ngồi không được nên mới tìm cách gì đó để hóa giải dịch bệnh nên đó cũng là lúc chị đọc được cuốn sách về giả kim thuật, thứ chị mong rằng là phép màu.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = "Thật trớ trêu cả cha và những người trong làng đều không tin vào giả kim thuật vì chị chỉ làm thứ mà không ai nghĩ đến.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Không thể tin được. Cho dù thế chị vẫn tiếp tục việc học giả kim thuật ư?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế nhưng mẹ chị đã... bà ấy đã tới giới hạn và chuyện gì cũng đã đến. Lúc ấy cha và chị chỉ có chết lặng...";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thôi được rồi, em hiểu rồi và có lẽ có hơi hiểu lầm về chị. Cho em xin lỗi!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị đã không thể bảo vệ ai hết cũng như mọi người đều không tin chị!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Được rồi mọi chuyện đã qua rồi! Đối với em chị đã làm một việc vô cùng tốt đó là ngăn chặn con golem sắt ngoài kia nếu không thị trấn lúc này không được yên tĩnh như vậy rồi!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không chỉ thế chị đã dạy cho em kiến thức về giả kim thuật. Một người như chị em rất tôn trọng!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne... Chị hiểu rồi! Có vẻ như định mệnh đưa hai ta gặp nhau nếu thế chị đã quyết định rồi!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị sẽ đồng hành cùng em để tìm tung tích của cha em.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì tốt quá, cảm ơn chị và mong được chỉ dạy!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Có vẻ chị đã có thay đổi so với trước nhỉ! Có thể là được một người tốt như em đồng hành cùng!";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe! Nếu không có gì nữa chúng ta chuẩn bị lên đường thôi!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus25 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.Bom -= 1;
                SceneManager.LoadScene("Save room");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus25 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.Bom -= 1;
        SceneManager.LoadScene("Save room");
    }
}