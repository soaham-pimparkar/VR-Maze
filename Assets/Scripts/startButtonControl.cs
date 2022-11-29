using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonControl : MonoBehaviour
{
    private bool startFlag = false;
    private float count = 2;
    private float counter;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    public void buttonEntered(){
        startFlag = true;
    }

    public void buttonExited(){
        startFlag = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(startFlag){
            counter += Time.deltaTime;
        }

        if(counter>=count){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
