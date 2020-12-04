using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEscapeMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject SecretDeveloperMenu;

    void Update()
    {
        if (Input.GetKeyDown("escape")){
            if(Panel.activeSelf){
                Panel.SetActive(false);
            }
            else{
                Panel.SetActive(true);
                SecretDeveloperMenu.SetActive(false);
            }
        }
        else if(Input.GetKeyDown("f1")){
            if (Panel.activeSelf){
                if (SecretDeveloperMenu.activeSelf){
                    SecretDeveloperMenu.SetActive(false);
                }
                else {
                    SecretDeveloperMenu.SetActive(true);
                }
            }
        }
    }
}
