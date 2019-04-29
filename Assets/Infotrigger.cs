using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Infotrigger : MonoBehaviour
{   private string Updatetext;
    private TextMesh textObject;
    //[SerializeField] private Animator myAnimationController;
    //AudioSource audioSource;

    private void Start()
    {   
     textObject = GameObject.Find("Saturn_text").GetComponent<TextMesh>();
     textObject.text="Saturn";
        //audioSource = GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.text="Saturn Facts \n Aphelion 	 10.086 AU 	 (1,509 Gm) \n Perihelion		 9.024 AU 	 (1,350 Gm) \n Semi-major axis 	 9.554909 AU 	 1,429.39 Gm. \n Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. \n It is a gas giant with an average radius about nine times that of Earth.\n Although only one-eighth the average density of Earth, \n with its larger volume Saturn is just over 95 times more massive. \n Saturn is named after the Roman god of agriculture; \n its astronomical symbol (♄) represents the god's sickle.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.text="Saturn";
        }
    }
}

