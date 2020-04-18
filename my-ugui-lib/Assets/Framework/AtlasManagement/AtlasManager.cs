using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
public class AtlasManager : MonoBehaviour
{
    private static Dictionary<string, AtlasCollection> AtlasHolder = new Dictionary<string, AtlasCollection>();

    public static void LoadAtlas(string atlasAlias,string atlasPath)
    {
        SpriteAtlas atlas = Resources.Load<SpriteAtlas>(atlasPath);
        if (atlas == null)
        {
            Debug.LogErrorFormat("{AtlasManager} Load Atlas Error: file not exist at : {0}", atlasPath);
        }
        if (AtlasHolder.ContainsKey(atlasAlias))
        {
            
        }
    }

    //public static SpriteAtlas GetAtlas(string atlasName, bool loaded = true)
    //{


    //}


    public class AtlasCollection
    {
        public SpriteAtlas Atlas { get; private set; }
        public int ReferenceCount { get; private set; }

        public AtlasCollection(SpriteAtlas _atlas)
        {
            Atlas = _atlas;
        }

        public void Refere()
        {
            ReferenceCount++;
        }

        public void Release()
        {
            ReferenceCount--;
        }
    }
}
