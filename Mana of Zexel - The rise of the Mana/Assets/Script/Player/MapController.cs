using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    //public Transform target2;
    public static bool WishingHillToZexelTown, ZexelTownToTavern, TavernToSaveRoom, ZexelTownToGroceryStore, ZexelTownToWeaponStore, ZexelTownToWishingForest, ZexelTownToInfernoDesert;
    public static bool ZexelTownToWishingHill, TavernToZexelTown, SaveRoomToTavern, GroceryStoreToZexelTown, WeaponStoreToZexelTown, WishingForestToZexelTown, InfernoDesertToZexelTown;

    // Start is called before the first frame update
    void Start()
    {
        if (WishingHillToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", 5);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            WishingHillToZexelTown = false;
        }
        else if (ZexelTownToWishingHill == true)
        {
            PlayerPrefs.SetFloat("x", -59);
            PlayerPrefs.SetFloat("y", -14);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWishingHill = false;
        }
        else if (ZexelTownToTavern == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToTavern = false;
        }
        else if (TavernToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -42);
            PlayerPrefs.SetFloat("y", -2);
            PlayerPrefs.SetFloat("z", 0);
            TavernToZexelTown = false;
        }
        else if (TavernToSaveRoom == true)
        {
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            TavernToSaveRoom = false;
        }
        else if (SaveRoomToTavern == true)
        {
            PlayerPrefs.SetFloat("x", 4.5f);
            PlayerPrefs.SetFloat("y", 4);
            PlayerPrefs.SetFloat("z", 0);
            SaveRoomToTavern = false;
        }
        else if (ZexelTownToGroceryStore == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToGroceryStore = false;
        }
        else if (GroceryStoreToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -60);
            PlayerPrefs.SetFloat("y", -10);
            PlayerPrefs.SetFloat("z", 0);
            GroceryStoreToZexelTown = false;
        }
        else if (ZexelTownToWeaponStore == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWeaponStore = false;
        }
        else if (WeaponStoreToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -21);
            PlayerPrefs.SetFloat("y", -18);
            PlayerPrefs.SetFloat("z", 0);
            WeaponStoreToZexelTown = false;
        }
        else if (ZexelTownToWishingForest == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 14);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWishingForest = false;
        }
        else if (WishingForestToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -48);
            PlayerPrefs.SetFloat("y", -40);
            PlayerPrefs.SetFloat("z", 0);
            WishingForestToZexelTown = false;
        }
        else if (ZexelTownToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -1.25f);
            PlayerPrefs.SetFloat("y", 9);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToInfernoDesert = false;
        }
        else if (InfernoDesertToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -71.5f);
            PlayerPrefs.SetFloat("y", -21.5f);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToZexelTown = false;
        }

        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }
}
