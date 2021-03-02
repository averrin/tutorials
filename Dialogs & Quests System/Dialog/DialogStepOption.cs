using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace InkRain {
	public class DialogStepOption : MonoBehaviour
	{
		[MultiLineProperty(3)]
		public string Text;
		public bool isEnd = false;
		
				
		void Start() {
			if(isEnd) gameObject.tag = "EndStep";
		}
	}
}