using UnityEngine;
using System.Collections;

/// <summary>
/// 一般放到第一个启动的Scene中，以后都不删除
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class SingletonDontDestroy<T> : MonoBehaviour where T:SingletonDontDestroy<T>{

    public static SingletonDontDestroy<T> _instance;

    public static T GetInstance() {
        if (Object.ReferenceEquals(_instance, null))
        {
            return null;
        }
        return (T)_instance;
    }

    public virtual void Awake() {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject);
            Init();
        }
        else if (_instance != this) {
            Debug.LogWarning(_instance.name + "already created, destroy this new one!");
            Destroy(this.gameObject);
            return;
        }
    }

    protected virtual void Init() { 
    
    
    }

    protected virtual void OnDestroy() {
        _instance = null;
    }

    public void OnApplicationQuit() {
        Destroy(gameObject);
        _instance = null;
    }

}
