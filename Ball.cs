using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Reference and Variables setup
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Use StartCoroutine to start the coroutine
        StartCoroutine(DeleteCanvasAfterDelay());
    }

    // Reset each time player scores
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    // Initially Launch the Ball
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    IEnumerator DeleteCanvasAfterDelay()
    {
        Debug.Log("Coroutine started");
        // Wait for 10 seconds
        yield return new WaitForSeconds(10f);

        // Find the Canvas with the specified tag
        GameObject canvas = GameObject.FindGameObjectWithTag("Help Screen");

        // Check if the Canvas is found
        if (canvas != null)
        {
            // Destroy the Canvas GameObject
            Destroy(canvas);
        }
        else
        {
            Debug.LogError("Canvas with tag '" + "Help Screen" + "' not found!");
        }
        // Call Launch after starting the coroutine
        Launch();
    }
}
