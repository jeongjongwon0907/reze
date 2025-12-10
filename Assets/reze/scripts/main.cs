using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace reze
{
    public class main : MonoBehaviour
    {

        public GameObject Menuback;
        public GameObject Manual;
        public GameObject story;

        public void BtnManual()
        {
            Menuback.GetComponent<Animator>().SetTrigger("close");
            Invoke("openManual", 1.5f);
        }

        public void Btnstory()
        {
            Menuback.GetComponent<Animator>().SetTrigger("close");
            Invoke("openstory", 1.5f);
        }

        void openManual()
        {
            Manual.SetActive(true);
            Manual.GetComponent<Animator>().SetTrigger("open");
        }

        void openMenuBack()
        {
            Menuback.GetComponent<Animator>().SetTrigger("open");
        }

        void openstory()
        {
            story.SetActive(true);
            story.GetComponent<Animator>().SetTrigger("open");
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void bunBack(int num)
        {
            switch (num)
            {
                case 0:
                    Manual.GetComponent<Animator>().SetTrigger("close");
                    Invoke("openMenuBack", 1.5f);
                    break;
                case 1:
                    story.GetComponent<Animator>().SetTrigger("close");
                    Invoke("openMenuBack", 1.5f);
                    break;
            }


        }

        public void btnsrart()
        {
            SceneManager.LoadScene("stage1");
        }

        public void btnquit()
        {
            Application.Quit();
        }
    }
}
