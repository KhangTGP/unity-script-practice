using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateBlock(PrimitiveType.Cube, 0, 0, 0);
        CreateBlock(PrimitiveType.Cube, -0.5f, 1, 0);
        CreateBlock(PrimitiveType.Cube, 0.5f, 1, 0);
        CreateBlock(PrimitiveType.Cube, 0.5f, 2, 0);
        CreateBlock(PrimitiveType.Cube, -0.5f, 2, 0);
        CreateBlock(PrimitiveType.Sphere, 0, 3, 0);
    }

    // Update is called once per frame
    void CreateBlock(PrimitiveType type, float x, float y, float z)
    {
        GameObject.CreatePrimitive(type).transform.position = new Vector3(x, y, z);
    }
}
