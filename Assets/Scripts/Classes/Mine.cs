using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mine : MonoBehaviour
{
    // parent of the three block buttons.
    public GameObject blocks;
    private List<Item> currentBlocks = new List<Item>();

    public AudioClip[] soundEffectArray;
    public AudioSource effectSource;
    public AudioClip breakSoundEffect;

    public GameObject inventoryFullText;

    // Starts with three random blocks.
    void Start()
    {  
        for (int i = 0; i < blocks.transform.childCount; i++){
            // add item Icon / Name to the buttons
            Item newBlock = getNewBlock();
            setNewBlock(newBlock, i);

            currentBlocks.Add(newBlock);
            // add item to inventory on click. needs to be local variable else handle always get i (3)
            int temp = i;

            Button individualBlock = blocks.transform.GetChild(i).GetComponent<Button>();
            individualBlock.onClick.AddListener(() => handleBlockClick(temp));
        }
    }

    private Item getNewBlock() {
        ItemFactory factory = null;

        // decide which block to spawn
        switch(Random.Range(1, 12)){
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
            case 11:
                factory = new GraniteItemFactory();
                break;
            default:
                Debug.Log("A block was attempted to get, but doesn't exist! Defaulting to stone.");
                factory = new StoneItemFactory();
                break;
        }

        return factory.GetItem();
    }

    private void setNewBlock(Item newBlock, int blockPos) {
        Text blockText = blocks.transform.GetChild(blockPos).GetComponentInChildren(typeof(Text)) as Text;
        blockText.text = newBlock.ItemName;
        blocks.transform.GetChild(blockPos).GetComponent<Image>().sprite = newBlock.Icon;
    }

    private void handleBlockClick(int blockPos){
        if (Inventory.Instance.getCurrItemCount() >= 100){
            // too many item
            Debug.Log("Full Inventory");
            effectSource.PlayOneShot(breakSoundEffect);
            inventoryFullText.SetActive(true);

            StartCoroutine(hideInventoryFull());
            return;
        }

        effectSource.PlayOneShot(soundEffectArray[Random.Range(0, 4)]);

        // add the item clicked
        Inventory.Instance.addItem(currentBlocks[blockPos]);
        // create a new block
        Item newBlock = getNewBlock();
        // set the image and text to the new block
        setNewBlock(newBlock, blockPos);
        // update the array of blocks accordingly
        currentBlocks[blockPos] = newBlock;
    }

    IEnumerator hideInventoryFull() {
        yield return new WaitForSeconds(2);
        inventoryFullText.SetActive(false);
    }
}
