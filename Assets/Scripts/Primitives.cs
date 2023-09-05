using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);

        while (true){
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0.5f, 0);

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 1.5f, 0);

            GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            capsule.transform.position = new Vector3(2, 1, 0);

            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = new Vector3(-2, 1, 0);

            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 2.5f, 0);

            GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 3.5f, 0);

            GameObject capsule2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            capsule.transform.position = new Vector3(2, 3, 0);
        }
    }

    // Update is called once per frame
   // void Update()
    //{
        
   // }
}