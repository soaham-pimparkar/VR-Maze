﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private bool isWalking;
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWalking){
            transform.position = transform.position + Camera.main.transform.forward *5f *Time.deltaTime;
        }
        if(transform.position.y < -10f){
            transform.position = spawnPoint;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f,.5f,0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.tag.Contains("ground")){
                isWalking = false;
            }
            else
            {
                isWalking = true;
            }
        }
        
    }
}
