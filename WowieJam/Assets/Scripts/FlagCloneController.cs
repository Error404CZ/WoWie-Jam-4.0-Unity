using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCloneController : MonoBehaviour
{
    
    public FlagController flagController;
    public AIController aiController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            flagController.isFlagable = true;
            aiController.EffectReseter();
            Destroy(gameObject);
        }
    }
}
