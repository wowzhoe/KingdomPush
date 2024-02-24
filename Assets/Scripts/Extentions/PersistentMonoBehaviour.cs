using UnityEngine;

public abstract class PersistentMonoBehaviour<T>: MonoBehaviour where T : MonoBehaviour {
    private static GameObject _instance;

    public static T Instance {
        get {
            if (_instance == null) {
                _instance = new GameObject("[Singleton] " + typeof(T));
                _instance.AddComponent<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance.GetComponent<T>();
        }
    }

    public void ForceInstantiate() { return; }
}
