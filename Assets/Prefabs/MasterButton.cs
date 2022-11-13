using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MasterButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;
    [SerializeField] GameObject button4;
    [SerializeField] GameObject button5;


    void Start(){
        // button.gameObject.SetActive(true);
    }
    public void OnClick(){
        button1.gameObject.SetActive(!button1.gameObject.active);
        button2.gameObject.SetActive(!button2.gameObject.active);
        button3.gameObject.SetActive(!button3.gameObject.active);
        button4.gameObject.SetActive(!button4.gameObject.active);
        button5.gameObject.SetActive(!button5.gameObject.active);
    }
}