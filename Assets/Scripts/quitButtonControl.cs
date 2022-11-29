using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitButtonControl : MonoBehaviour
{
    private bool quitFlag = false;
    private float count = 2;
    private float counter;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    public void buttonEntered(){
        quitFlag = true;
    }

    public void buttonExited(){
        quitFlag = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(quitFlag){
            counter += Time.deltaTime;
        }

        if(counter>=count){
            Application.Quit();
            //EditorApplication.ExitPlaymode();
        }
    }
}
