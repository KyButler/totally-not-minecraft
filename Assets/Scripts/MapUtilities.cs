using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUtilities : MonoBehaviour
{
    public GameObject Map;
    public Text mapText;

    public GameObject Mines;
    public GameObject Shop;

    public void openMap()
    {
        if (Map.activeSelf){
            Map.SetActive(false);
            mapText.text = "Map";
        }
        else{
            Map.SetActive(true);
            mapText.text = "Close Map";
        }
    }

    public void travel(string destination) {
        switch (destination){ 
            case "Mines":
                Mines.SetActive(true);
                Shop.SetActive(false);
                break;
            case "Shop":
                Shop.SetActive(true);
                Mines.SetActive(false);
                break;
            case "Default":
                Debug.Log("Not sure where you want to travel, sending to Shop!");
                Shop.SetActive(true);
                Mines.SetActive(false);
                break;
        }
        Map.SetActive(false);
        mapText.text = "Map";
    }
}
