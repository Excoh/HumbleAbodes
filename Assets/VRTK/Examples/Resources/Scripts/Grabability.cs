namespace  VRTK.Examples
{ 
using UnityEngine;


    public class Grabability : VRTK_InteractableObject
    {
        private Vector3 currentPos;
        public override void StartUsing(GameObject currentUsingObject)
        {
            base.StartUsing(currentUsingObject);
            currentUsingObject.GetComponent<VRTK_InteractTouch>().ForceTouch(this.gameObject);
            //currentPos = transform.position;
            //currentPos.y = currentPos.y + 3;
            //currentUsingObject.transform.position = currentPos; 
        }

        public override void StopUsing(GameObject usingObject)
        {
            base.StopUsing(usingObject);
            StopTouching(usingObject);
        }
        // Update is called once per frame

        protected override void Start()
        {
            base.Start();
        }

    }

}
