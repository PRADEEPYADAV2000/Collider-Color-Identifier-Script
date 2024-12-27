using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ColliderColorChanger : MonoBehaviour
{
   
    public Color colliderColor = Color.red; 

    
    private void OnDrawGizmos()
    {
        
        Gizmos.color = colliderColor;

        if (TryGetComponent(out BoxCollider boxCollider))
        {
            Gizmos.DrawCube(boxCollider.bounds.center, boxCollider.bounds.size);
        }

        
        else if (TryGetComponent(out SphereCollider sphereCollider))
        {
            Gizmos.DrawSphere(sphereCollider.bounds.center, sphereCollider.radius);
        }
    } 
    
}
