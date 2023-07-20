using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URPPlacesController : MonoBehaviour
{
    public Volume _volume;
    private Bloom _bloom;
    private Vignette _vignette;
    private WhiteBalance _whiteBalance;
    private ShadowsMidtonesHighlights _shadowsMidtonesHighlights;

    public static bool UpdateURP, TurnOffURP;

    // Start is called before the first frame update
    void Start()
    {
        _volume.profile.TryGet(out _bloom);
        _volume.profile.TryGet(out _vignette);
        _volume.profile.TryGet(out _whiteBalance);
        _volume.profile.TryGet(out _shadowsMidtonesHighlights);

        TurnOffURP = false;

        URPChange();
    }

    // Update is called once per frame
    void Update()
    {
        if (UpdateURP == true)
        {
            UpdateURP = false;

            URPChange();
        }

        if (TurnOffURP == true)
        {
            TurnOffURP = false;
            _bloom.active = false;
            _vignette.active = false;
            _whiteBalance.active = false;
            _shadowsMidtonesHighlights.active = false;
        }
    }

    public void URPChange()
    {
        if (DateController.DayOn == true)
        {
            if (GraphicSettingController.Bloom == 1)
            {
                _bloom.active = true;
                _bloom.intensity.value = 0.4f;
            }
            if (GraphicSettingController.Vignette == 1)
            {
                _vignette.active = false;
            }
            if (GraphicSettingController.WhiteBalance == 1)
            {
                _whiteBalance.active = false;
            }
            if (GraphicSettingController.HightlightShadow == 1)
            {
                _shadowsMidtonesHighlights.active = true;
                _shadowsMidtonesHighlights.shadows.overrideState = true;
                _shadowsMidtonesHighlights.midtones.overrideState = false;
                _shadowsMidtonesHighlights.highlights.overrideState = false;
            }
        }
        else if (DateController.NightOn == true)
        {
            if (GraphicSettingController.Bloom == 1)
            {
                _bloom.active = true;
                _bloom.intensity.value = 0.6f;
            }
            if (GraphicSettingController.Vignette == 1)
            {
                _vignette.active = true;
            }
            if (GraphicSettingController.WhiteBalance == 1)
            {
                _whiteBalance.active = true;
            }
            if (GraphicSettingController.HightlightShadow == 1)
            {
                _shadowsMidtonesHighlights.active = true;
                _shadowsMidtonesHighlights.shadows.overrideState = true;
                _shadowsMidtonesHighlights.midtones.overrideState = true;
                _shadowsMidtonesHighlights.highlights.overrideState = true;
            }
        }
    }
}
