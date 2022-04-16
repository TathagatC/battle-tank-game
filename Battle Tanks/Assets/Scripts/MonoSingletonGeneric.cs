using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T: MonoSingletonGeneric<T>
{
    private static T instance;
    public T Instance { get { return instance; }}
    
    private void Awake() 
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }
}

public class PlayerTank : MonoSingletonGeneric<PlayerTank>{}

public class EnemyTank : MonoSingletonGeneric<EnemyTank>{}
