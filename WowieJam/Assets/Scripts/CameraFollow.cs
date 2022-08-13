using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10);
    [SerializeField] private float smoothTime;
    private Vector3 velocity = Vector3.zero;
    
    [SerializeField] private Transform player;
    
    void Update()
    {
        Vector3 playerPosition = player.position + offset;
        transform.position=Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, smoothTime);
    }
}
