using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P1NGMU
{
    [System.Serializable]
    public enum ltemStatus
    {
        hp,
        upgrade,
        bomb
    }
    public class item : MonoBehaviour
    {
        public float itemSpeed = -0.25f;
        public ltemStatus itemStatus = ltemStatus.hp;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + Time.deltaTime * itemSpeed);

        }
    }
}
