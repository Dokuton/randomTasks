using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawn
{
    public class UiController : MonoBehaviour
    {
        public static event Action<int> OnDelayValueChanged;
        public static event Action<int> OnSpeedValueChanged;
        public static event Action<int> OnDistanceValueChanged;


        public void OnDelayEndEdit(string value)
        {
            var parsedValue = int.Parse(value);
            OnDelayValueChanged?.Invoke(parsedValue);
        }

        public void OnSpeedEndEdit(string value)
        {
            var parsedValue = int.Parse(value);
            OnSpeedValueChanged?.Invoke(parsedValue);
        }

        public void OnDistanceEndEdit(string value)
        {
            var parsedValue = int.Parse(value);
            OnDistanceValueChanged?.Invoke(parsedValue);
        }
    }
}