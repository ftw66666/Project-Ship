using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//命名空间声明

public class Event : MonoBehaviour
{
    public static event Action Dropdown;
    public static event Action<int> SwitchBackground;



    public static void CallDropdown()
    {
        Dropdown?.Invoke();
    }
    public static void CallSwitchBackground(int id)
    {
        SwitchBackground?.Invoke(id);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
