using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mathProblemPrefab; // Voeg hier de MathProblemWithPipes prefab toe
    public float spawnInterval = 5f; // Tijd tussen spawns
    public float spawnXPosition = 10f; // X-positie waar de prefab spawnt

    private void Start()
    {
        InvokeRepeating(nameof(SpawnMathProblem), 2f, spawnInterval); // Spawnt elke 'spawnInterval' seconden
    }

    private void SpawnMathProblem()
    {
        // Instantiate een nieuwe prefab
        GameObject newMathProblem = Instantiate(mathProblemPrefab);
        newMathProblem.transform.position = new Vector3(spawnXPosition, 0, 0); // Stel de spawn-positie in
    }
}

public class PipeMovement : MonoBehaviour
{
    public float speed = 5f; // Snelheid waarmee de pipes bewegen

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // Beweeg naar links
    }
}