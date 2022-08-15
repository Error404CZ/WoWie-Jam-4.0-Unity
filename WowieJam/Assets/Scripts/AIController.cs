using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime;
    private Vector3 velocity = Vector3.zero;
    
    [SerializeField] private Transform player;

    private List<bool> effects = new List<bool>();

    [SerializeField] private List<GameObject> blockParts = new List<GameObject>();

    public Vector2 targetTransform;
    
    public FlagController flagController;
    
    void Start()
    {
        
        EffectReseter();
        //EffectActivator(1);
        effects.Add(true);
        effects.Add(false);
        effects.Add(false);

        foreach (var x in blockParts)
        {
            x.SetActive(false);
        }
        blockParts[0].SetActive(true);

    }

    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            EffectReseter();
            //EffectActivator(1);
            effects[0] = true;
        }else if(Input.GetKeyDown(KeyCode.Q) && !flagController.isFlagable)
        {
            EffectReseter();
            //EffectActivator(2);
            effects[1] = true;
        }else if(Input.GetKeyDown(KeyCode.E) && !flagController.isFlagable)
        {
            EffectReseter();
            //EffectActivator(3);
            effects[2] = true;
        }
        
        

        if (effects[1])
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetTransform, ref velocity, smoothTime);
            foreach (var x in blockParts)
            {
                x.SetActive(false);
            }
            blockParts[1].SetActive(true);
           
        }
        else if (effects[2] && !flagController.isFlagable)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetTransform, ref velocity, smoothTime);
            foreach (var x in blockParts)
            {
                x.SetActive(false);
            }
            blockParts[2].SetActive(true);
           
        }
        else
        {
            Vector3 playerPosition = player.position + offset;
            transform.position=Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, smoothTime);
            foreach (var x in blockParts)
            {
                x.SetActive(false);
            }
            blockParts[0].SetActive(true);
           
        }
        
        
    }
    
    /*
    public void EffectActivator(int effectKey)
    {
        switch (effectKey)
        {
            case 1:
                effects[0] = true;
                
                Vector3 playerPosition = player.position + offset;
                transform.position=Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, smoothTime);
                Debug.Log("1");
                
                break;
            case 2:
                effects[1] = true;
                while (effects[1] == true)
                {
                    Debug.Log("2");
                }
                break;
        }
    }
*/
    
    public void EffectReseter()
    {
        for (var i = 0; i < effects.Count; i++)
        {
            effects[i] = false;
        }
    }
    
}
