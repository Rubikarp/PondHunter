using UnityEngine;

public class RestrictedArea : MonoBehaviour
{
    [Header("Edges")]
    [SerializeField] private Color borderColor = Color.red;
    [SerializeField] private Transform firstCorner, secondCorner = null;

    public bool CanMoveInDir(Transform Object, Vector3 Direction)
    {
        Vector3 objectNextPos = Object.position + Direction.normalized;

        //vérifie si l'on sera bien entre les deux points en X
        if (objectNextPos.x < firstCorner.position.x && objectNextPos.x < secondCorner.position.x
         || objectNextPos.x > firstCorner.position.x && objectNextPos.x > secondCorner.position.x)
        {
            return false;
        }

        //vérifie si l'on sera bien entre les deux points en Y
        if (objectNextPos.y < firstCorner.position.y && objectNextPos.y < secondCorner.position.y
         || objectNextPos.y > firstCorner.position.y && objectNextPos.y > secondCorner.position.y)
        {
            return false;
        }

        return true;

    }

    public bool InZone(Transform Object)
    {
        Vector2 objectPos = new Vector2(Object.position.x, Object.position.y);

        //vérifie si l'on est bien entre les deux points en X
        if (objectPos.x < firstCorner.position.x && objectPos.x < secondCorner.position.x 
         || objectPos.x > firstCorner.position.x && objectPos.x > secondCorner.position.x)
        {
            return false;
        }


        //vérifie si l'on est bien entre les deux points en Y
        if (objectPos.y < firstCorner.position.y && objectPos.y < secondCorner.position.y
         || objectPos.y > firstCorner.position.y && objectPos.y > secondCorner.position.y)
        {
            return false;
        }
        
        return true;
        
    }

    private void OnDrawGizmos()
    {
        float ZoneHeight = firstCorner.position.y - secondCorner.position.y;
        float ZoneLength = firstCorner.position.x - secondCorner.position.x;

        Debug.DrawRay(secondCorner.position, Vector3.up    * ZoneHeight, borderColor);
        Debug.DrawRay( firstCorner.position, Vector3.left  * ZoneLength, borderColor);
        Debug.DrawRay( firstCorner.position, Vector3.down  * ZoneHeight, borderColor);
        Debug.DrawRay(secondCorner.position, Vector3.right * ZoneLength, borderColor);
    }

}
