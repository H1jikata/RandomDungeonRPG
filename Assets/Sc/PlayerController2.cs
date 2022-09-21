using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    void Update()
    {
        //今後QとEを使ってゲームをつくるためコントローラーを使ったゲームはつくらないと判断したため
        //Input.GetAxisではなくGetKeyDownを使っています。
        if(Input.GetKeyDown("w"))
        {
            this.transform.Translate(1, 0, 0);
        }

        if(Input.GetKeyDown("s"))
        {
            this.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown("a"))
        {
            this.transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown("d"))
        {
            this.transform.Translate(0, 0, -1);
        }
    }
}
