using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaGem : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaGem;

        if (ContainerController.ManaGem <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
