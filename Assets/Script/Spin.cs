using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private GameObject go;

	void Start () 
    {
		
	}
	

	void Update () 
    {
        Vector3 axis = new Vector3 (1.0f, 1.0f, 0.0f);

        float angle = 60f * Time.deltaTime;

        Quaternion q = Quaternion.AngleAxis (angle, axis);

        this.go.transform.rotation = q * this.transform.rotation;
	}
}
