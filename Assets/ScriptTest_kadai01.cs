using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest_kadai01 : MonoBehaviour {

	void Start () {
		// 配列arrayを宣言して好きな値で初期化
		int[] array = { 51, 32, 43, 14, 75};


		// 配列の各要素の値を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log ("順　" + (i+1) + "番目　＝　" + array [i]);
		}

		// for文を使い配列の各要素を逆順表示
		for (int i = (array.Length-1); i >= 0; i--) {
			Debug.Log ("逆　" + (i+1) + "番目　＝　" + array [i]);

		}
	}

	void Update () {

	}
}