using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    // Use this for initialization
    [System.Obsolete]
    void Start()
    {
        player = gameObject.transform.FindChild("Player(Clone)").gameObject;
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, 6.0f * Time.deltaTime);
    }
}
