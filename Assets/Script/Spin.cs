using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private GameObject go;

    private Vector3 axis = new Vector3(0, 0, 0);

    private float axisX;
    private float axisY;

	void Start () 
    {
		
	}
	

	void Update () 
    {
        this.axisX = Mathf.Sin (Time.frameCount / 100.0f);
        this.axisY = Mathf.Cos (Time.frameCount / 100.0f);

        this.axis.x = this.axisX;
        this.axis.y = this.axisY;

        float angle = 90f * Time.deltaTime;

        Quaternion q = Quaternion.AngleAxis (angle, axis);

        this.go.transform.rotation = q * this.transform.rotation;
	}
}
