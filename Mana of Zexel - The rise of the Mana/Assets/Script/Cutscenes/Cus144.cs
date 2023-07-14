using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus144 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject ZexelVAL1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggggg...";
            }
            else if (tang == 2)
            {
                ZexelVAL1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Remember one more thing. Unity is the key to victory.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Zexel";
                dia.text = "I used to be with my friends.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zexel";
                dia.text = "Especially the older sister that I respect a lot.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zexel";
                dia.text = "An alchemist with red hair named Maria helped me win the battle with Sicxalon.";
            }
            else if (tang == 6)
            {
                ZexelVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "To be countinute...";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus144 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Epilogue");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggggg...";
            }
            else if (tang == 2)
            {
                ZexelVAL1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Hãy nhớ rằng một điều nữa. Đoàn kết là chìa khóa chiến thắng.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Zexel";
                dia.text = "Tôi đã từng đồng hành với những người bạn của tôi.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zexel";
                dia.text = "Đặc biệt là người chị mà tôi rất quý trọng.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zexel";
                dia.text = "Một nhà giả kim với mái tóc đỏ Maria đã giúp tôi chiến thắng trong trận chiến với Sicxalon.";
            }
            else if (tang == 6)
            {
                ZexelVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Còn tiếp...";
            }
            else if (tang >= 7)
            {
                CutscenesController.cus144 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Epilogue");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 1)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 2)
        {
            cc.FXCutscenesStop();
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus144 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Epilogue");
    }
}