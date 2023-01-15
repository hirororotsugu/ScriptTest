using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53; // mp
    public void Magic()
    {
        // 魔法用の関数
        if(this.mp >= 5 )
        {
            // mpが5以上の場合
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            // mpが5未満の場合
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        // 要素の個数5個の配列arrayを宣言し値を初期化
        int[] array = { 100, 200, 300, 400, 500};

        // for文を使い、配列の要素(5個)ぶんだけ処理する
        for (int i =0; i < array.Length; i++)
        {
            // 配列の要素を順番に表示する
            Debug.Log(array[i]);
        }

        // for文を使い、配列の順序を逆順で処理
        for (int i = array.Length -1; i >= 0; i--)
        {
            // 配列の要素を(逆)順に表示する
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();
        // 魔法用の関数を11回呼び出す
        for (int i = 1; i <= 11; i++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
