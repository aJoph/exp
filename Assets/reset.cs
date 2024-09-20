using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{

	GameObject Onion;
	// Start is called before the first frame update
	void Start()
    {
		Onion = GameObject.Find("yellow_onion_1k");
	}

    // Update is called once per frame
    void Update()
    {
		if (Onion.transform.position.y < 10)
        {
            Debug.Log("Onion should transport now!!!!");
            Onion.transform.position = new Vector3(10, 15, 175);
        }

    }
}
