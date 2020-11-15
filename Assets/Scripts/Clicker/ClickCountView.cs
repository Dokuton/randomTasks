using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    public class ClickCountView : MonoBehaviour
    {
        [SerializeField] private Text countText;


        private void OnEnable()
        {
            countText.text = "0";
        }

        public void ShowClicksCount(string newValue)
        {
            countText.text = newValue;
        }
    }
}
