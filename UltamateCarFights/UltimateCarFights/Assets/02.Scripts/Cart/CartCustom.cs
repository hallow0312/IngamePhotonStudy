using UltimateCartFights.Utility;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Resources;

namespace UltimateCartFights.Game
{
    public class CartCustom : MonoBehaviour
    {
        [SerializeField] private SkinnedMeshRenderer renderer;
        [SerializeField] private Image backCharacter; 
        [SerializeField] private Image frontCharacter;

        public int character;
        public int color;

        private void Start()
        {
            SetCharacter(character);
            SetColor(color);
        }

        private void SetColor(int color)
        {
            renderer.material = ResourcesManager.Instance.ColorMaterials[color];
        }

        private void SetCharacter(int character)
        {
            backCharacter.sprite = ResourcesManager.Instance.Characters[character];
            frontCharacter.sprite = ResourcesManager.Instance.Characters[character];
        }
    }
}