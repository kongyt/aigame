using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class Line : MonoBehaviour {

    public Transform from;
    public Transform to;

    private LineRenderer renderer;
    private bool isDrawing = false;

	// Use this for initialization
	void Start () {
        renderer = gameObject.GetComponent<LineRenderer>();
        renderer.SetWidth(0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (from != null && to != null)
        {
            renderer.SetPosition(0, from.transform.position);
            renderer.SetPosition(1, to.transform.position);
        }
	}
}
