using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceManaGeneratorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus86 == 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
