using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    private float startingRotation;

    void Start(){
        this.startingRotation = Random.Range(0, 360f);
    }

    void Update (){
        float rotation = (Time.time + startingRotation) % 360;

        RenderSettings.skybox.SetFloat("_Rotation", rotation);
    }
}
