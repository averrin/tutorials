using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using ProceduralToolkit;

namespace InkRain {
    public class Dialog : MonoBehaviour
	{
		public bool Active = true;
		public List<DialogStep> AvailableSteps = new List<DialogStep>();
		public UnityEvent<DialogStep> OnStepShow;
		public UnityEvent<DialogStepOption> OnOptionChoose;

        void Update()
        {
	        gameObject.tag = Active ? "DialogActive" : "DialogInactive";
        }
        
		public DialogStep GetStep() {
			if(AvailableSteps.Count == 0) return null;
	    	return AvailableSteps.GetRandom();
	    }
    }
}