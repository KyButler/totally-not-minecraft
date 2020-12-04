using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;

public class Load : MonoBehaviour
{
    public GameObject continueGameButton;
    // Start is called before the first frame update
    void Start()
    {
        // see if save file exists
        string destination = Application.persistentDataPath + "/save.json";;
        FileStream file;

        if (File.Exists(destination)) {
            file = File.OpenRead(destination);
            Debug.Log("File Exists!");
        }
        else {
            Debug.Log("No Save Data.");
            continueGameButton.GetComponent<Button>().interactable = false;
            return;
        }
 
        file.Close();
    }

    public void buttonHandling(bool shouldContinue){
        ShouldLoad.Yes = shouldContinue;
    }
}
