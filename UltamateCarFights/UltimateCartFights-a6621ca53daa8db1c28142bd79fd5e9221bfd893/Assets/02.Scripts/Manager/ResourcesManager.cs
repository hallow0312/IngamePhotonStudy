using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UltimateCartFights.Utility
{
    public class ResourcesManager : MonoBehaviour
    {
        [Header("Character Sprites")]
        public List<Sprite> Characters;
        [Header("Cart Color Material")]
        public List<Material> ColorMaterials;

        public static ResourcesManager Instance = null;

        private void Awake()
        {
            if (Instance) { Destroy(gameObject); return; }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
