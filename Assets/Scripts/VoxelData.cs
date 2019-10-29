﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData
{

    public static readonly int ChunkWidth = 16;
    public static readonly int ChunkHeight = 128;
    public static readonly int WorldSizeInChunks = 100;
    
    public static int WorldSizeInVoxels
    {
        get { return WorldSizeInChunks * ChunkWidth; }
    }

    public static readonly int ViewDistanceInChunks = 5;

    public static readonly int TextureAtlasSizeInBlocks = 16;
    public static float NormalizedBlockTextureSize
    {
        get { return 1f / (float)TextureAtlasSizeInBlocks; }
    }

    public static readonly Vector3[] voxelVerts = new Vector3[8]
    {
        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f)
    };

    public static readonly Vector3[] faceChecks = new Vector3[6]
    {
        new Vector3(0.0f, 0.0f, -1.0f), // Z axis negative (Back)
        new Vector3(0.0f, 0.0f, 1.0f),  // Z axis positive (Front)
        new Vector3(0.0f, 1.0f, 0.0f),  // y axis positive (Top)
        new Vector3(0.0f, -1.0f, 0.0f), // y axis negative (Bottom)
        new Vector3(-1.0f, 0.0f, 0.0f), // x axis negative (Left)
        new Vector3(1.0f, 0.0f, 0.0f)   // x axis positive (Right)
    };

    //// Voxel triangles for each face ordered by clockwise selection for generating correct normals
    //public static readonly int[,] voxelTris = new int[6, 6]
    //{
    //    {0, 3, 1, 1, 3, 2 },    // Back Face
    //    {5, 6, 4, 4, 6, 7 },    // Front Face
    //    {3, 7, 2, 2, 7, 6 },    // Top Face
    //    {1, 5, 0, 0, 5, 4 },    // Bottom Face
    //    {4, 7, 0, 0, 7, 3 },    // Left Face
    //    {1, 2, 5, 5, 2, 6 }     // Right Face
    //};

    //Voxel triangles(Squares this time) for each face ordered by clockwise selection for generating correct normals
    public static readonly int[,] voxelTris = new int[6, 4]
    {
        {0, 3, 1, 2 },    // Back Face
        {5, 6, 4, 7 },    // Front Face
        {3, 7, 2, 6 },    // Top Face
        {1, 5, 0, 4 },    // Bottom Face
        {4, 7, 0, 3 },    // Left Face
        {1, 2, 5, 6 }     // Right Face
    };

    //public static readonly Vector2[] voxelUvx = new Vector2[6]
    //{
    //    new Vector2(0.0f, 0.0f),
    //    new Vector2(0.0f, 1.0f),
    //    new Vector2(1.0f, 0.0f),
    //    new Vector2(1.0f, 0.0f),
    //    new Vector2(0.0f, 1.0f),
    //    new Vector2(1.0f, 1.0f)
    //};

    public static readonly Vector2[] voxelUvx = new Vector2[4]
    {
        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 1.0f)
    };


}
