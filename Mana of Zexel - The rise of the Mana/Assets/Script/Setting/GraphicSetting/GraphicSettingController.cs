using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSettingController : MonoBehaviour
{
    public AudioSource ClickFX;
    public GameObject BloomOn, BloomOff, VignetteOn, VignetteOff, WhiteBalanceOn, WhiteBalanceOff, HightlightShadowOn, HightlightShadowOff;

    public static int Bloom, Vignette, WhiteBalance, HightlightShadow;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SBloom"))
        {
            Bloom = 0;
        }
        else
        {
            Bloom = PlayerPrefs.GetInt("SBloom");
        }

        if (!PlayerPrefs.HasKey("SVignette"))
        {
            Vignette = 0;
        }
        else
        {
            Vignette = PlayerPrefs.GetInt("SVignette");
        }

        if (!PlayerPrefs.HasKey("SWhiteBalance"))
        {
            WhiteBalance = 0;
        }
        else
        {
            WhiteBalance = PlayerPrefs.GetInt("SWhiteBalance");
        }

        if (!PlayerPrefs.HasKey("SHightlightShadow"))
        {
            HightlightShadow = 0;
        }
        else
        {
            HightlightShadow = PlayerPrefs.GetInt("SHightlightShadow");
        }

        if (Bloom == 0)
        {
            BloomOn.SetActive(false);
            BloomOff.SetActive(true);
        }
        else if (Bloom == 1)
        {
            BloomOn.SetActive(true);
            BloomOff.SetActive(false);
        }

        if (Vignette == 0)
        {
            VignetteOn.SetActive(false);
            VignetteOff.SetActive(true);
        }
        else if (Vignette == 1)
        {
            VignetteOn.SetActive(true);
            VignetteOff.SetActive(false);
        }

        if (WhiteBalance == 0)
        {
            WhiteBalanceOn.SetActive(false);
            WhiteBalanceOff.SetActive(true);
        }
        else if (WhiteBalance == 1)
        {
            WhiteBalanceOn.SetActive(true);
            WhiteBalanceOff.SetActive(false);
        }

        if (HightlightShadow == 0)
        {
            HightlightShadowOn.SetActive(false);
            HightlightShadowOff.SetActive(true);
        }
        else if (HightlightShadow == 1)
        {
            HightlightShadowOn.SetActive(true);
            HightlightShadowOff.SetActive(false);
        }
    }

    public void OnBloomPress()
    {
        ClickFX.Play();
        Bloom = 0;
        BloomOn.SetActive(false);
        BloomOff.SetActive(true);
        PlayerPrefs.SetInt("SBloom", Bloom);
    }

    public void OffBloomPress()
    {
        ClickFX.Play();
        Bloom = 1;
        BloomOn.SetActive(true);
        BloomOff.SetActive(false);
        PlayerPrefs.SetInt("SBloom", Bloom);
    }

    public void OnVignettePress()
    {
        ClickFX.Play();
        Vignette = 0;
        VignetteOn.SetActive(false);
        VignetteOff.SetActive(true);
        PlayerPrefs.SetInt("SVignette", Vignette);
    }

    public void OffVignettePress()
    {
        ClickFX.Play();
        Vignette = 1;
        VignetteOn.SetActive(true);
        VignetteOff.SetActive(false);
        PlayerPrefs.SetInt("SVignette", Vignette);
    }

    public void OnWhiteBalancePress()
    {
        ClickFX.Play();
        WhiteBalance = 0;
        WhiteBalanceOn.SetActive(false);
        WhiteBalanceOff.SetActive(true);
        PlayerPrefs.SetInt("SWhiteBalance", WhiteBalance);
    }

    public void OffWhiteBalancePress()
    {
        ClickFX.Play();
        WhiteBalance = 1;
        WhiteBalanceOn.SetActive(true);
        WhiteBalanceOff.SetActive(false);
        PlayerPrefs.SetInt("SWhiteBalance", WhiteBalance);
    }

    public void OnHightlightShadowPress()
    {
        ClickFX.Play();
        HightlightShadow = 0;
        HightlightShadowOn.SetActive(false);
        HightlightShadowOff.SetActive(true);
        PlayerPrefs.SetInt("SHightlightShadow", HightlightShadow);
    }

    public void OffHightlightShadowPress()
    {
        ClickFX.Play();
        HightlightShadow = 1;
        HightlightShadowOn.SetActive(true);
        HightlightShadowOff.SetActive(false);
        PlayerPrefs.SetInt("SHightlightShadow", HightlightShadow);
    }
}
