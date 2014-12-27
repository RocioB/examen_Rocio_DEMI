using UnityEngine;
using System.Collections;

public class cambioDeNivel : MonoBehaviour {

	public class cambioNivel : MonoBehaviour {
		public string namelevel;
		
		
		public void pasarnivel(){
			
			Application.LoadLevel (namelevel);
			
			
		}
	}
}