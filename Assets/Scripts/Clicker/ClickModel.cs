using UnityEngine;

namespace Clicker
{
    public class ClickModel : MonoBehaviour
    {
        private ushort _clickCount;


        public void AddClick()
        {
            _clickCount++;
        }

        public string GetClickCountString()
        {
            return _clickCount.ToString();
        }
    }
}
