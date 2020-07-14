using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    // The speed that the GameObject will move
    private float _speed = 10;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += (Vector3.forward * _speed) * Time.deltaTime;
        }
        // Move the GameObject up this frame


    }

}
