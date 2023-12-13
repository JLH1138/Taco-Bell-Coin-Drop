using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class jumpscript : MonoBehaviour
{
    private bool isJumping = false;

    void Update()
    {
        // Check for the A button press
        //if (Input.GetButtonDown("Jump") && !isJumping)
        //{
        //    StartCoroutine(Jump());
        //}
    }

    IEnumerator Jump()
    {
        // Perform the jump logic here
        Debug.Log("Jump!");

        // Simulate a jump by moving the player up
        float jumpHeight = 1.0f;
        float jumpDuration = 0.5f;
        float elapsedTime = 0f;

        Vector3 initialPosition = transform.position;

        while (elapsedTime < jumpDuration)
        {
            transform.position = Vector3.Lerp(initialPosition, initialPosition + Vector3.up * jumpHeight, elapsedTime / jumpDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the player is back on the ground
        transform.position = initialPosition + Vector3.up * jumpHeight;

        isJumping = false;
    }
}
