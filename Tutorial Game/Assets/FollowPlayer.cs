using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Transform ground;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

        if (player.position.y <= -50)
        {
            transform.LookAt(ground);
        }
        
    }
}
