using UnityEngine;
using System.Collections;

public class scr_P_Health : MonoBehaviour 
	{
		//variable declaration
	    public GameObject myObject;
		bool alive = true;
		static int startingHealth = 100;
		int currentHealth = startingHealth;
		//end declaration	

		public static void Awake ()
		{
		
		}
		
		void Update ()
		{
		startingHealth --;

			while (alive = true) {


			if (currentHealth <= 0) {			//check if player is alive
		 		death();
			}
			}
		}
		public void death(){
		gameObject.SetActive(false); 			//disable object
			//Kill Screen
			//end screen
			
			
		}
		
	}