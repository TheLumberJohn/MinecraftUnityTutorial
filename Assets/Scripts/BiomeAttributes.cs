﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BiomeAttributes", menuName = "MinecraftTutorial/Biome Attributes")]
public class BiomeAttributes : ScriptableObject
{
    public string biomeName;

    public int solidGroundHeight;
    public int terrainHeight;
    public float terrainScale;

    [Header("Trees")]
    public float treeZoneScale = 1.3f;
    public float treePlacementScale = 15f;
    [Range(0.1f, 1f)]
    public float treeZoneThreshold = 0.6f;
    [Range(0.1f, 1f)]
    public float treePlacementThreshold = 0.8f;

    public int minTreeHeight = 5;
    public int maxTreeHeight = 12;

    public Lode[] lodes;
}

[System.Serializable]
public class Lode
{
    public string lodeName;
    public byte blockID;
    public int minHeight;
    public int maxHeight;
    public float scale;
    public float threshold;
    public float noiseOffset;
}
