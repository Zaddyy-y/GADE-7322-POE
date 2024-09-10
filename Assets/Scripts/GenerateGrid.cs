using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateGrid : MonoBehaviour
{
    GridCells[,] gridCell; //2D array for grid cells
    public int gridSize = 100; //size of the grid
    public float gridScale = .1f; //scale of the grid
    public float [,] noiseMap; //2D array for the noise map
    public float noiseValue; // stores the value of the noise map
    public Mesh mesh;
   

    public struct GridCells //custom value type for the grid cells
    {
        
    }


    void Start()
    {
        NoiseMap();
        Grid();
    }

    void OnDrawGizmos()
    {
        if (!Application.isPlaying)  //returns if the application is in play mode
        {
            return;
        }

        for (int y = 0; y < gridSize; y++) // Loops through the y axis (rows)
        {
            for (int x = 0; x < gridSize; x++) // Loops through the x axis (columns)
            {
                GridCells cells = gridCell[x, y]; //FInd the current cells x and y coordinates
                

                Vector3 position = new Vector3(x, 0, 0); //creates a position for the specfic current cell
                Gizmos.DrawCube(position, Vector3.one); //draws a cube at the specfic position
            }
        }
    }


    void Grid()
    {
        gridCell = new GridCells[gridSize, gridSize]; //creating a new 2D gridCells array with the given size value
        for(int y = 0; y < gridSize; y++) //Loops through the rows and columns of the grid
        {
            for(int x = 0; x < gridSize; x++)
            {
                GridCells cells = new GridCells(); //new grid cells object is created
                
                gridCell[x, y] = cells;  //the created cell is put on the grid
            }
        }
    }

    void NoiseMap()
    {
        noiseMap = new float[gridSize, gridSize]; //new array to store perlin noise values
        for (int y = 0;y < gridSize;y++)
        {
            for (int x = 0;x < gridSize;x++)
            {
                noiseValue = Mathf.PerlinNoise(x * gridScale , y * gridScale ); //calculating the perlin noise values for a cell
                noiseMap[x, y] = noiseValue; //storing the calculated noise value in the new array
            }
        }
    }
    
}
                

   






