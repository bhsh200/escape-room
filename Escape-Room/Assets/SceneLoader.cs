using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Transform targetObject; // Assign the target object (e.g., a door or portal).
    public float transitionRadius= 7f; // Adjust this distance as needed.
    public string sceneToLoad = "Ending"; // The name of the scene to load.

    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObject.position);

        if (distance <= transitionRadius)
        {
            // Load the designated scene.
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
