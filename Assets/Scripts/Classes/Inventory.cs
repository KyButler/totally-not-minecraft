using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

// Singleton OOP Pattern.
public class Inventory : MonoBehaviour {
    private static Inventory _instance;
    public static Inventory Instance { get { return _instance; } }

    private int money;
    public Text moneyText;

    public GameObject notEnoughMoneyText;

    public Text inventoryButtonText;    
    public GameObject inventoryPanel;
    public GameObject inventoryWrapper;

    public GameObject endScreen;

    List<Item> items = new List<Item>();

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.Log("Tried to load another Signleton, got dunked.");
            Destroy(this.gameObject);
        } else {
            Debug.Log("Loading Inventory Singleton");
            _instance = this;
        }

        if (ShouldLoad.Yes){
            // load game
            Debug.Log("Inventory is trying to load the save file");

            string saveFile = Application.persistentDataPath + "/save.json";;

            if (File.Exists(saveFile)) {
                string json = File.ReadAllText(saveFile);
                Save save = JsonUtility.FromJson<Save>(json);
                addMoney(save.money);
                foreach (string item in save.itemNames){
                    ItemFactory factory = null;
                    switch(item){
                        case "Coal":
                            factory = new CoalItemFactory();
                            break;
                        case "Diamond":
                            factory = new DiamondItemFactory();
                            break;
                        case "Stone":
                            factory = new StoneItemFactory();
                            break;
                        case "Redstone":
                            factory = new RedstoneItemFactory();
                            break;
                        case "Iron":
                            factory = new IronItemFactory();
                            break;
                        case "Emerald":
                            factory = new EmeraldItemFactory();
                            break;
                        case "Andesite":
                            factory = new AndesiteItemFactory();
                            break;
                        case "Gold":
                            factory = new GoldItemFactory();
                            break;
                        case "Lapis":
                            factory = new LapisItemFactory();
                            break;
                        case "Diorite":
                            factory = new DioriteItemFactory();
                            break;
                        default:
                            Debug.Log("A block was attempted to get, but doesn't exist! Defaulting to stone.");
                            factory = new StoneItemFactory();
                            break;
                    }
                    addItem(factory.GetItem());
                }
            }
            else {
                Debug.LogError ("File exists but it doesn't exist??");
            }
        }
        else {
            Debug.Log("Inventory is DESTROYING the save file!");
            string saveFile = "Assets/save.json";
            File.Delete(saveFile);
        }
    }

    public void addItem(Item item){
        items.Add(item);
    }

    public int getCurrItemCount(){
        return items.Count;
    }

    public void printItems(){
        Debug.Log("printItems called");

        foreach(Item item in items){
            Debug.Log(item.ItemName + item.Price);
        }
    }

    // this is OP, and ONLY for debugging.
    public void addFiftyItems(){
        Debug.Log("addFiftyItems called");
        ItemFactory factory = null;
        for (int i = 0; i < 50; i++){
            // decide which block to spawn
        switch(Random.Range(1, 11)){
            case 1:
                factory = new CoalItemFactory();
                break;
            case 2:
                factory = new DiamondItemFactory();
                break;
            case 3:
                factory = new StoneItemFactory();
                break;
            case 4:
                factory = new RedstoneItemFactory();
                break;
            case 5:
                factory = new IronItemFactory();
                break;
            case 6:
                factory = new EmeraldItemFactory();
                break;
            case 7:
                factory = new AndesiteItemFactory();
                break;
            case 8:
                factory = new GoldItemFactory();
                break;
            case 9:
                factory = new LapisItemFactory();
                break;
            case 10:
                factory = new DioriteItemFactory();
                break;
            default:
                Debug.Log("A block was attempted to get, but doesn't exist! Defaulting to stone.");
                factory = new StoneItemFactory();
                break;
        }
        addItem(factory.GetItem());
        }
    }

    public void toggleInventory(){
        if (inventoryWrapper.activeSelf){
            foreach (Transform child in inventoryPanel.transform){
                GameObject.Destroy(child.gameObject);
            }

            inventoryWrapper.SetActive(false);
            inventoryButtonText.text = "Inventory";
        } else {
            generateUI();
            inventoryWrapper.SetActive(true);
            inventoryButtonText.text = "Close";
        }
    }

    public void generateUI(){
        foreach(Item item in items){
            GameObject UItem = new GameObject(item.ItemName);
            UItem.AddComponent<Image>();
            UItem.GetComponent<Image>().sprite = item.Icon;
            UItem.transform.SetParent(inventoryPanel.transform, false);
        }
    }

    private void addMoney(int add){
        money += add;
        moneyText.text = "$" + money;
    }

    private void deductMoney(int deduct){
        money -= deduct;
        moneyText.text = "$" + money;
    }

    public void sellEverything(){
        foreach(Item item in items){
            addMoney(item.Price);
        }

        items.Clear();
        
    }

    public void buyBeatTheGame(){
        if (money >= 10000){
            // deductMoney(10000);
            // beat the game condition
            endScreen.SetActive(true);
        }
        else {
            notEnoughMoneyText.SetActive(true);

            StartCoroutine(hideNotEnoughMoneyText());
        }
    }

    IEnumerator hideNotEnoughMoneyText(){
        yield return new WaitForSeconds(2);
        notEnoughMoneyText.SetActive(false);
    }

    public void saveGame() {
        // load game
        Debug.Log("Inventory is trying to save the save file.");

        string saveFile = Application.persistentDataPath + "/save.json";

        Save save = new Save();
        save.money = money;

        List<string> tempList = new List<string>();
        foreach (Item item in items){
            tempList.Add(item.ItemName);
        }

        save.itemNames = tempList;

        File.WriteAllText(saveFile, JsonUtility.ToJson(save));
    }
}
