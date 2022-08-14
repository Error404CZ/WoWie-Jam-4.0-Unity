using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime;
    private Vector3 velocity = Vector3.zero;
    
    [SerializeField] private Transform player;
    void Start()
    {
        
    }

    
    
    void Update()
    {
        Vector3 playerPosition = player.position + offset;
        transform.position=Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, smoothTime);
    }
}
