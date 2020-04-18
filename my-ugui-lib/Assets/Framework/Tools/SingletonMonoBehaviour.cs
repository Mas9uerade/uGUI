using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MasUGUILib.Tools
{
    public class SingletonMonoBehaviour<T> : MonoBehaviour
    {
        private static SingletonMonoBehaviour<T> mInstance;

        public static SingletonMonoBehaviour<T> Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = FindObjectOfType<SingletonMonoBehaviour<T>>();
                    if (mInstance == null)
                    {
                        mInstance = FindObjectOfType<Root>().gameObject.AddComponent<SingletonMonoBehaviour<T>>();
                    }
                }
                return mInstance;
            }
        }
    }
}

