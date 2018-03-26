using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
		private int hp = 100;
		private int mp = 53;
		private int power = 25;

		public void Attack(){
			Debug.Log(this.power + "のダメージを与えた！");
		}

		public void Defence(int damage){
			Debug.Log(damage + "のダメージを受けた！");
			this.hp -= damage;
		}

	//　BossクラスにMagic関数（魔法）を追加
		public void Magic(int UseMagic){
			if (this.mp >= UseMagic) {
			this.mp -= UseMagic;
			Debug.Log ("魔法を回使用した。残りＭＰは" + mp);	
			}else{
				Debug.Log ("ＭＰが足りないため魔法が使えない");
		}
	}
}



public class ScriptTest_kadai02 : MonoBehaviour {
	

		void Start () {
			Boss lastboss = new Boss ();
			lastboss.Attack ();
			lastboss.Defence (3);

		// 魔法複数使用のfor文を追加
		for(int i = 0; i <= 10; i++){
			lastboss.Magic (5);
		}
	}


		void Update () {

		}
}
