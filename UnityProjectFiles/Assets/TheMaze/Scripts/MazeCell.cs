﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell : MonoBehaviour {

    public IntVector2 coordinates;

    private MazeCellEdge[] edges = new MazeCellEdge[MazeDirections.Count];

    private int initializedEdgeCount;

    public MazeRoom room;

    public void Initialize(MazeRoom room)
    {
        room.Add(this);
        transform.GetChild(0).GetComponent<Renderer>().material = room.settings.floorMaterial;
    }

    public bool IsFullyInitialized
    {
        get
        {
            return initializedEdgeCount == MazeDirections.Count;
        }
    }

    public void SetEdge(MazeDirection direction, MazeCellEdge edge)
    {
        edges[(int)direction] = edge;
        initializedEdgeCount += 1;
    }

    public MazeCellEdge GetEdge(MazeDirection direction)
    {
        return edges[(int)direction];
    }

    public MazeDirection RandomUninitializedDirection
    {
        get
        {
            int skips = Random.Range(0, MazeDirections.Count - initializedEdgeCount);
            for (int i = 0; i < MazeDirections.Count; i++)
            {
                if (edges[i] == null)
                {
                    if (skips == 0)
                    {
                        return (MazeDirection)i;
                    }
                    skips -= 1;
                }
            }
            throw new System.InvalidOperationException("MazeCell has no uninitialized directions left.");
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Lock()
    {
        for (int i = 0; i < edges.Length; i++)
        {
            if (edges[i] is MazeDoor)
            {
                MazeDoor door = edges[i] as MazeDoor;
                door.Lock();
            }
        }
    }

    public void Unlock()
    {
        for (int i = 0; i < edges.Length; i++)
        {
            if (edges[i] is MazeDoor)
            {
                MazeDoor door = edges[i] as MazeDoor;
                door.Unlock();
            }
        }
    }
}
