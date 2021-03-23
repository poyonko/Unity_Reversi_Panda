﻿using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲームプレイ中・現在のターン表示を示すクラス（Player）
/// </summary>
public class UI_Player_Select_Color : MonoBehaviour
{  
    [SerializeField]
    Sprite[] UI_StoneColor = new Sprite[2];

    public void Play_UIStoneStart(E_StoneState selectStone)
    {
        if (selectStone == E_StoneState.BLACK)
        {
            this.GetComponent<Image>().sprite = UI_StoneColor[(int)UI_Managaer.E_UIStone_color.eUI_BLACK];
        }
        else {

            this.GetComponent<Image>().sprite = UI_StoneColor[(int)UI_Managaer.E_UIStone_color.eUI_WHITE];
        }
    }

}
