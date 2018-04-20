using UnityEngine;
namespace SUIFW
{
    public class Test3 : MonoBehaviour
    {
        private void Start()
        {
            RigisterButtonEventOnEnter(p => Debug.Log("Button :" + this.gameObject.name)    );
        }

        protected void RigisterButtonEventOnEnter(EventTriggerListener.VoidDelegate delHandle)
        {
                EventTriggerListener.Get(this.gameObject).onEnter = delHandle;
        }

        
    }
}

