using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitEvent : MonoBehaviour
{
    public void IsQuit (bool quit)
{
    if (quit) {
        //退出游戏
        Application.Quit();
    }
}
}
