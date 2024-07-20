using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class DropdownManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    void Start()
    {
        // 设置监听
        SetDropdownAddListener(OnValueChanged);
    }
 
    /// <summary>
    /// 当点击后值改变是触发 (切换下拉选项)
    /// </summary>
    /// <param name="v">是点击的选项在OptionData下的索引值</param>
    void OnValueChanged(int v)
    {
        //切换选项 时处理其他的逻辑...
        Debug.Log("点击下拉控件的索引是..." + v);
        Debug.Log(v.ToString());
        Debug.Log(dropdown.options[dropdown.value].text);
    }

    void SetDropdownAddListener(UnityAction<int> OnValueChangeListener)
    {
        
 
        //当点击后值改变是触发 (切换下拉选项)
        dropdown.onValueChanged.AddListener((value)=> {
            OnValueChangeListener(value);
        });
    }
}
