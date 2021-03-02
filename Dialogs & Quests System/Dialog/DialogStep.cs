using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Linq;

namespace InkRain {
	public class DialogStep : MonoBehaviour
	{
		[MultiLineProperty(3)]
		public string Text;
		public List<DialogStepOption> Options => 
			GetComponentsInChildren<DialogStepOption>().ToList();
	}
}