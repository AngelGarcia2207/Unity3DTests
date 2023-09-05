using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTriangle : MonoBehaviour
{

    public static Vector4 Vector3To4(Vector3 inVec)
    {
        Vector4 outVec = new Vector4(inVec.x, inVec.y, inVec.z, 1);
        return outVec;
    }


    public static Vector3 Vector4To3(Vector4 inVec)
    {
        Vector3 outVec = new Vector3(inVec.x, inVec.y, inVec.z);
        return outVec;
    }

    //Geometry
    Vector3[] points1;
    //Topology
    int[] tris1;

    // Start is called before the first frame update
    void Start()
    {

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh1 = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh1;

        //Geometry
        points1 = new Vector3[3];

        points1[0] = new Vector3(0, 0, -1);
        points1[1] = new Vector3(5, 0, -1);
        points1[2] = new Vector3(2, 5, -1);

        //Topology
        tris1 = new int[3];

        tris1[0] = 0;
        tris1[1] = 2;
        tris1[2] = 1;

        mesh1.vertices = points1;
        //mesh.uv = newUV;
        mesh1.triangles = tris1;
        mesh1.RecalculateNormals();


        //Material colour
        //myRenderer = GetComponent<MeshRenderer>();
        Color myColour = new Color(0.8f, 0.5f, 0.2f, 1.0f);
        GetComponent<MeshRenderer>().material.color = myColour;
    }

    // Update is called once per frame
    void Update()
    {
        Matrix4x4 transform1 = Transformations.RotateM(1, Transformations.AXIS.AX_Y);

        points1[0] = transform1 * Vector3To4(points1[0]);
        points1[1] = transform1 * Vector3To4(points1[1]);
        points1[2] = transform1 * Vector3To4(points1[2]);
        GetComponent<MeshFilter>().mesh.vertices = points1;
    }
}