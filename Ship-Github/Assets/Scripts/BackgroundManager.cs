using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class BackgroundManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    const int numBG = 2;
    public GameObject[] background = new GameObject[numBG];

    void Start()
    {
        // 设置监听
        SetDropdownAddListener(OnValueChanged);
    }

    void OnValueChanged(int v)
    {
        Debug.Log(v.ToString() + "-Hello");
        for(int i=0;i<=numBG;i++)
        {
            if(i == v) background[i].SetActive(true);
            else background[i].SetActive(false);
        }
    }

    void SetDropdownAddListener(UnityAction<int> OnValueChangeListener)
    {
        
 
        //当点击后值改变是触发 (切换下拉选项)
        dropdown.onValueChanged.AddListener((value)=> {
            OnValueChangeListener(value);
        });
    }


}
