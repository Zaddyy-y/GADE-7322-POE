using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateGrid : MonoBehaviour
{
    GridCells[,] gridCell;
    public int gridSize = 100;
    public float gridScale = .1f;
    public float [,] noiseMap;
    public float noiseValue;
    public float offsetX = 100f;
    public float offsetY = 100f;
    public Mesh mesh;
   

    public struct GridCells
    {
        public int Height;
    }


    void Start()
    {
        offsetX = Random.Range(0f, 1000f);
        offsetY = Random.Range(0f, 1000f);
        NoiseMap();
        Grid();
        GenerateMesh(gridCell);
        
    }

    void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            return;
        }

        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                GridCells cells = gridCell[x, y];
                Gizmos.color = UnityEngine.Color.yellow;

                Vector3 position = new Vector3(x, 0, y);
                Gizmos.DrawCube(position, Vector3.one);
            }
        }
    }


    void Grid()
    {
        gridCell = new GridCells[gridSize, gridSize];
        for(int y = 0; y < gridSize; y++)
        {
            for(int x = 0; x < gridSize; x++)
            {
                GridCells cells = new GridCells();
                
                gridCell[x, y] = cells;  
            }
        }
    }

    void NoiseMap()
    {
        noiseMap = new float[gridSize, gridSize];
        for (int y = 0;y < gridSize;y++)
        {
            for (int x = 0;x < gridSize;x++)
            {
                noiseValue = Mathf.PerlinNoise(x * gridScale + offsetX, y * gridScale + offsetY);
                noiseMap[x, y] = noiseValue;
            }
        }
    }

    

    void GenerateMesh(GridCells[,] gridCell)
    {
        Mesh gridMesh = new Mesh();
        
        int width = gridCell.GetLength(0);
        int height = gridCell.GetLength(1);
        Vector3[] vertices = new Vector3[width * height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                vertices[x + y * width] = new Vector3(x, gridCell[x, y].Height, y);
            }
        }

        
        int[] triangles = new int[(width - 1) * (height - 1) * 6];
        int t = 0;
        for (int x = 0; x < width - 1; x++)
        {
            for (int y = 0; y < height - 1; y++)
            {
                int bottomLeft = x + y * width;
                int bottomRight = (x + 1) + y * width;
                int topLeft = x + (y + 1) * width;
                int topRight = (x + 1) + (y + 1) * width;

                triangles[t++] = bottomLeft;
                triangles[t++] = topLeft;
                triangles[t++] = bottomRight;
                triangles[t++] = bottomRight;
                triangles[t++] = topLeft;
                triangles[t++] = topRight;


            }

        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        
        mesh.RecalculateNormals();
        
        GetComponent<MeshFilter>().mesh = mesh;
    }

    
}
                

   






