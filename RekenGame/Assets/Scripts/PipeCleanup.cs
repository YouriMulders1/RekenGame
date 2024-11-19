using UnityEngine;

public class PipeCleanup : MonoBehaviour
{
    public float cleanupXPosition = -15f; // X-positie waarop het object wordt verwijderd

    private void Update()
    {
        if (transform.position.x < cleanupXPosition)
        {
            Destroy(gameObject); // Verwijder het object als het buiten beeld is
        }
    }
}
