using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManage : MonoBehaviour {
    public Object knife;

    private WaitForSeconds cooldown;

	// Use this for initialization
	void Start () {
        cooldown = new WaitForSeconds(1);
        Object.Instantiate(knife);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0))
        {
            Object.Instantiate(knife);
        }
	}
}
