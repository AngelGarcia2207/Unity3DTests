using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class BoxProcedural : MonoBehaviour
{
   public int size;
	
	[SerializeField] private Texture DieTexture;
	
	private Texture DieTexture2;

	// Start is called before the first frame update
	void Start()
	{
		Mesh mesh = gameObject.AddComponent<MeshFilter>().mesh;
		MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, size, 0),
            new Vector3(0, 0, 0),
            new Vector3(size, size, 0),
            new Vector3(size, 0, 0),
            new Vector3(0, 0, size),
            new Vector3(size, 0, size),
            new Vector3(0, size, size),
            new Vector3(size, size, size),
            new Vector3(0, size, 0),
            new Vector3(size, size, 0),
            new Vector3(0, size, 0),
            new Vector3(0, size, size),
            new Vector3(size, size, 0),
            new Vector3(size, size, size),
        };

        int[] triangles = {
            0, 2, 1, // front
            1, 2, 3,
            4, 5, 6, // back
            5, 7, 6,
            6, 7, 8, //top
            7, 9 ,8, 
            1, 3, 4, //bottom
            3, 5, 4,
            1, 11,10,// left
            1, 4, 11,
            3, 12, 5,//right
            5, 12, 13 
        };

        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),
            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),
            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),
            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),
            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };  

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize (); // this is deprecated
        mesh.RecalculateNormals ();
		  
	meshRenderer.material.mainTexture = DieTexture;

	}
}
