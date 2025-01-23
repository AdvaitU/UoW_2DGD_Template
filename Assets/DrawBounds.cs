using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class DrawBounds : MonoBehaviour
{
    private Tilemap tilemap;
    [SerializeField]
    private Vector2 SizeInPixels;

    private void Start()
    {
        tilemap = GetComponent<Tilemap>();
        Debug.Log(this.name + "'s size in pixels: (" + tilemap.size.x * 100 + " x " + tilemap.size.y * 100 + ")");
    }

    private void OnApplicationQuit()
    {
        SizeInPixels.x = tilemap.size.x * 100;
        SizeInPixels.y = tilemap.size.y * 100;
    }

}
