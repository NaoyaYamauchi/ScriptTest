using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    //int型の変数mpを宣言し、53で初期化してください
    private int mp = 53;

    //mpを消費して魔法攻撃をするMagic関数を作ってください
    public void Magic()
    {
        //mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
        if (mp < 5)
        {
            
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            this.mp -= 5;
        }

    }

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start () {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = {540,810,1080,1350,2025};
        
        //配列の各要素の値を順番に表示してください
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        //for文を使い、配列の各要素の値を逆順に表示してください
        for(int i = array.Length-1; 0<=i; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();
        Boss midboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        //Magic関数を呼び出して、魔法を使ってください
        lastboss.Magic();
        //Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }

        midboss.Attack();
        midboss.Defence(22);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
