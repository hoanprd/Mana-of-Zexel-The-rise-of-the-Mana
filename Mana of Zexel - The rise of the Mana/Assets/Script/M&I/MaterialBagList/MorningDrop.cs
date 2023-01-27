using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorningDrop : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.MorningDrop;

        if (ContainerController.MorningDrop <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
