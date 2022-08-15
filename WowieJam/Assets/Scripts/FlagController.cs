using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    public AIController aiController;
    
    private Vector3 screenPosition;
    private Vector3 worldPosition;
    
    [SerializeField] private GameObject flag;
    
    public int flagCount;
    public bool isFlagable = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&& flagCount > 0&&isFlagable)
        {
            flagCount--;
            screenPosition = Input.mousePosition;

            worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            worldPosition.z = 0f;
            aiController.targetTransform = worldPosition;
            
            GameObject newInstance = Instantiate(flag);
            newInstance.transform.position = worldPosition;
            isFlagable = false;
        }
    }
}
