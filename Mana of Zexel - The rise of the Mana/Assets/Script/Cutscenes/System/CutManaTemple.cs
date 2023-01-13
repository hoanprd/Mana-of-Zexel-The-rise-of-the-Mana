using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutManaTemple : MonoBehaviour
{
    public GameObject CutTrigger1;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus51 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}
