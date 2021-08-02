//A script for the camera to follow the player lol

using UnityEngine;

public class MoveCamera : MonoBehaviour{
    public Transform layer;

    void Update() {
        transform.position = player.transform.position;
    
    }
}
