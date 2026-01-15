using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{

    public GameObject level1;
    public GameObject level2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LevelChange();
        }
    }

    private void LevelChange()
    {
        level1.SetActive(false);
        level2.SetActive(true);
    }
}
