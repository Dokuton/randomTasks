using UnityEngine;

namespace Clicker
{
    public class ClickController : MonoBehaviour
    {
        [SerializeField] private ClickCountView clickView;
        [SerializeField] private ClickModel clickModel;


        public void OnButtonClick()
        {
            clickModel.AddClick();
            var clicksString = clickModel.GetClickCountString();

            clickView.ShowClicksCount(clicksString);
        }
    }
}