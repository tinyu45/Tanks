using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShellExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 1.5f);  //1.5秒后删除
	}

}
