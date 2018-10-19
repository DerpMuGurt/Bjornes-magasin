using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class CosmeticScript : MonoBehaviour {

    public GameObject sadMask;
    public GameObject hat;
    //equip mask?
    //equipp equipped mask?
=======
using UnityEngine.UI;

public class CosmeticScript : MonoBehaviour {
<<<<<<< HEAD

    public GameObject sadMask;
    public GameObject hat;
    //equip mask?
    //equipp equipped mask?
<<<<<<< HEAD
=======
using UnityEngine.UI;
=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

    public GameObject sadMask;
    public GameObject hat;
    //equip mask?
    //equipp equipped mask?
=======
using UnityEngine.UI;




    public Button cosmeticMask1;
    public Button cosmeticMask2;
    public Button cosmeticMask3;
<<<<<<< HEAD
    public GameObject sadMask;
    public GameObject hat;
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> parent of 3d11d37... Fixed




    // Use this for initialization
    void Start() {

        sadMask.GetComponentInChildren<Renderer>().enabled = false;
        hat.GetComponentInChildren<Renderer>().enabled = true;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72



=======
=======
>>>>>>> parent of 3d11d37... Fixed
        cosmeticMask1.gameObject.SetActive(false);
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411

=======
=======
        cosmeticMask1.gameObject.SetActive(false);
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed

    }
<<<<<<< HEAD
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 3d11d37... Fixed
        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;
=======
<<<<<<< HEAD
=======

    // Update is called once per frame
    void Update() {
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72
=======
>>>>>>> parent of 3d11d37... Fixed

=======
>>>>>>> parent of 3d11d37... Fixed
        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;
=======

<<<<<<< HEAD
        if (Input.GetKeyDown("w"))
        {
            cosmeticMask1.gameObject.SetActive(true);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
        }

            if (Input.GetKeyDown("s"))
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> parent of 3d11d37... Fixed
            sadMask.GetComponentInChildren<Renderer>().enabled = false;
            hat.GetComponentInChildren<Renderer>().enabled = true;
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
=======
>>>>>>> parent of 3d11d37... Fixed
=======
=======
>>>>>>> parent of 3d11d37... Fixed
            cosmeticMask1.gameObject.SetActive(false);
        }
        cosmeticMask1.onClick.AddListener(PutOnMask);
=======
            if (Input.GetKeyDown("w"))//&& sad mask equipped
            {
                sadMask.GetComponentInChildren<Renderer>().enabled = true;
                hat.GetComponentInChildren<Renderer>().enabled = false;


                if (Input.GetKeyDown("w")) {
                    cosmeticMask1.gameObject.SetActive(true);

                }

                if (Input.GetKeyDown("s")) {

                    sadMask.GetComponentInChildren<Renderer>().enabled = false;
                    hat.GetComponentInChildren<Renderer>().enabled = true;
                }




                cosmeticMask1.gameObject.SetActive(false);
            }
            cosmeticMask1.onClick.AddListener(PutOnMask);

            if (Input.GetKeyDown("e")) {
                sadMask.GetComponentInChildren<Renderer>().enabled = false;
                hat.GetComponentInChildren<Renderer>().enabled = true;
            }
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

        }
<<<<<<< HEAD
        
    }
    void PutOnMask()
    {
        print("click on");
        sadMask.GetComponentInChildren<Renderer>().enabled = true;
        hat.GetComponentInChildren<Renderer>().enabled = false;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
    }
        void PutOnMask() {
            print("click on");
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;

        }
    
}
