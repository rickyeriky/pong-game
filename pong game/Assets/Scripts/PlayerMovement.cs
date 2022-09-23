using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    public float speed = 20;
    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player1") * Time.deltaTime * speed, 0));
        }

        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2") * Time.deltaTime * speed, 0));
        }
        transform.position = new Vector3(transform.position.x,
            Mathf.Clamp(transform.position.y, -8.5f, 8.5f), transform.position.z);
    }    
}
