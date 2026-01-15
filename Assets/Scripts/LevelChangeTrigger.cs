using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    private void Start()
    {
        levelManager = GameObject.FindAnyObjectByType<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelManager.LevelChange();
        }
    }

    
}
