using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URPIceController : MonoBehaviour
{
    public Volume _volume;
    private Bloom _bloom;
    private Vignette _vignette;
    private WhiteBalance _whiteBalance;
    private ShadowsMidtonesHighlights _shadowsMidtonesHighlights;

    // Start is called before the first frame update
    void Start()
    {
        _volume.profile.TryGet(out _bloom);
        _volume.profile.TryGet(out _vignette);
        _volume.profile.TryGet(out _whiteBalance);
        _volume.profile.TryGet(out _shadowsMidtonesHighlights);

        if (GraphicSettingController.Bloom == 1)
        {
            _bloom.active = true;
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
        }
    }
}
