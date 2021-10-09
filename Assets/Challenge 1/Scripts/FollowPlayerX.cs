using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(35, 4, 16);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Place the camera position on top of the player's position
        transform.position = player.transform.position + offset;
    }
}
