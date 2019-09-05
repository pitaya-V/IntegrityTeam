using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEditor : MonoBehaviour {
    [ContextMenuItem( "测试一波右键", "ContextMenultem" )]
    public int  test;

    // Use this for initialization
    void Start () {
		//测试
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [ContextMenu( "ContextMenu" )]
    public void ContextMenu() {


    }


    public void ContextMenultem() {


    }

}
