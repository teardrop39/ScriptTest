using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
				private int mp = 53; // 魔力

        // 攻撃用の関数
        public void Attack() {
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage) {
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

				// 魔法攻撃用の関数
				public void Magic(){
					     this.mp -= 5;

							 if(this.mp > 0){
						     Debug.Log("魔法攻撃をした。残りMPは"+ this.mp + "。");
							 }else{
						     Debug.Log("MPが足りないため魔法が使えない。");
							 }

				}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //課題
				//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        //配列の各要素の値を順番に表示してください
        //for文を使い、配列の各要素の値を逆順に表示してください

				int[] array = new int[5];
				array[0] = 11;
				array[1] = 21;
				array[2] = 32;
				array[3] = 40;
				array[4] = 93;

				for(int i = 0; i < array.Length; i++){
					    Debug.Log(array[i]);
				}

				for(int j = array.Length - 1; j >= 0; j--){
					    Debug.Log(array[j]);
				}


				//発展課題
				// Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();

                // 攻撃用の関数を呼び出す
                lastboss.Attack();
                // 防御用の関数を呼び出す
                lastboss.Defence(3);
								// 魔法攻撃の関数を呼び出す

								for(int i = 0; i <= 10; i++){
									    lastboss.Magic();
								}

	}

	// Update is called once per frame
	void Update () {

	}
}
