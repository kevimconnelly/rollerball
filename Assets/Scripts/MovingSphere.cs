using UnityEngine;

public class MovingSphere : MonoBehaviour {
    void Update()
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);
        Vector3 displacement = new Vector3(playerInput.x, 0f, playerInput.y);
        transform.localPosition += displacement;
    }
}
