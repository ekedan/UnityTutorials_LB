using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotA : MonoBehaviour {

	public Color color;
	public float size;
	public string liquidTypeName;
	//public Material mat;
	public Material googleMat;
	public MeshRenderer meshRenderer;

	public float fluidAmount;

	private Material defaultMaterial;

	void Start()
	{
		color = Color.grey;
		size = 1;
		liquidTypeName = "Tea";
		defaultMaterial = GameObject.Find ("Cube").GetComponent<MeshRenderer>().material;
		Debug.Log (defaultMaterial.name);

		googleMat = Resources.Load<Material> ("PinkPaint");


		//mat = gameObject.GetComponent<MeshRenderer> ().material;

		meshRenderer = gameObject.GetComponent<MeshRenderer> ();

		Debug.Log (meshRenderer);

		meshRenderer.material = googleMat;
		//gameObject.GetComponent<MeshRenderer> ().material = googleMat;
		//mat = googleMat;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			toggleMaterial ();
			pour ();
		}
	}

	public void pour()
	{
		//rotate 90 degrees
		//transform.Rotate(new Vector3(90,0,0));
		float rot = transform.rotation.x;

//		while (transform.rotation.x <= 90)
//		{
//			rot = Mathf.Lerp (transform.rotation.x, 90f, Time.deltaTime);
//		}

		//lift
	}

	public void heat()
	{

	}

	public void cool()
	{

	}

	public void changeLiquidType()
	{

	}

	public void changeMaterial()
	{
		meshRenderer.material = defaultMaterial;
	}

	public void toggleMaterial()
	{
		Debug.Log (meshRenderer.material);
		Debug.Log (googleMat);


		Debug.Log (meshRenderer.material.name);

		if (meshRenderer.material.name.Equals("PinkPaint (Instance)"))
		{
			//Debug.Log ("True");
			meshRenderer.material = defaultMaterial;
		} 
		else
		{
			meshRenderer.material = googleMat;
		}
	}
}
