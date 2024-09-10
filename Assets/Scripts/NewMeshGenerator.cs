using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class NewMeshGenerator : MonoBehaviour
{
    public Vector3 [] vertices; 
    public int[] triangles;
    public Mesh GridMesh;
    public float meshScale = 2f;
    public float newXPosition;
    public float newYPosition;
    public float newZPosition;


    void Start()
    {  
        GridMesh = new Mesh(); 
        MeshFilter meshFilter = GetComponent<MeshFilter>(); //assigning the new mesh to the meshfilter component
        meshFilter.mesh = GridMesh;

        meshFilter.transform.position = new Vector3(newXPosition, newYPosition, newZPosition); //setting the scale and position of the mesh
        meshFilter.transform.localScale *= meshScale;

        vertices = new Vector3[] //defining the vertices of the quad mesh
        {
            new Vector3(0,0,0),
            new Vector3(0,0,1),
            new Vector3(1,0,0),
            new Vector3(1,0,1),
        };

        triangles = new int[] //defining trainagles whihc make up the mesh
        {
            0,1,2,
            1,3,2
        };

        MeshUpdate();
    }

    void MeshUpdate()
    {
        GridMesh.Clear(); //clearing the mesh on start

        GridMesh.vertices = vertices; //assigning traingles and vertices to the mesh
        GridMesh.triangles = triangles;

        GridMesh.RecalculateNormals(); //reclaculating normals for lighting



    }
}
