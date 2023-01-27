using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCoreIceZexel : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCoreIceZexel;

        if (ContainerController.ManaCoreIceZexel <= 0)
        {
            Destroy(gameObject);
        }
    }
}
