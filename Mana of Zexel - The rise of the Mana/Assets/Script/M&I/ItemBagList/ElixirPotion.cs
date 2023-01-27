using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElixirPotion : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ElixirPotion;

        if (ContainerController.ElixirPotion <= 0)
        {
            Destroy(gameObject);
        }
    }
}
