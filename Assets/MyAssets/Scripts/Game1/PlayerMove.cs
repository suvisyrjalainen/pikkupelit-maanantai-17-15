using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(moveX, 0f, 0f) * speed * Time.deltaTime;
    }
}
