using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] bool _moveChage = true;
    //今後QとEを使ってゲームをつくるためコントローラーを使ったゲームはつくらないと判断したため
    //Input.GetAxisではなくGetKeyDownを使っています。
    void Update()
    {
        if(_moveChage == true)
        {
            PlayerMove1();
        }
        else
        {
            PlayerMove2();
        }
    }

    void PlayerMove1()
    {
        if (Input.GetKeyDown("w"))
        {
            this.transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown("s"))
        {
            this.transform.Translate(0, 0, -1);
        }

        if (Input.GetKeyDown("a"))
        {
            this.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            this.transform.Translate(1, 0, 0);
        }
    }

    void PlayerMove2()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Translate(0, 0, 1);
        }

        if (Input.GetKey("s"))
        {
            this.transform.Translate(0, 0, -1);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            this.transform.Translate(1, 0, 0);
        }
    }
}
