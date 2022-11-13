using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject panel;

    void Start(){
        text.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }
    public void OnClick(){
        // gameObject.SetActive(false);
        text.gameObject.SetActive(!text.gameObject.active);
        panel.gameObject.SetActive(!panel.gameObject.active);
    }
}
