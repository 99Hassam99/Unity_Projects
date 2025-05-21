using UnityEngine;

public class PersistentAudio : MonoBehaviour
{
    public static PersistentAudio Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
