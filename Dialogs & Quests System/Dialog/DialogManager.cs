using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using System.Linq;

namespace InkRain {
    public class DialogManager : MonoBehaviour
    {
        public string ActorName;
        
	    public Dialog GetDialog() {
	    	var d = GetComponentsInChildren<Dialog>();
	    	foreach (var item in d)
	    	{
	    		if(item.Active) return item;
	    	}
	    	return null;
	    }
	    
	    public DialogStep ShowDialogStep() {
	    	var d = GetDialog();
	    	if(d == null) return null;
	    	var s = d.GetStep();
	    	if(s == null) return s;
	    	d.OnStepShow.Invoke(s);
	    	return s;
	    }
	    
	    public void ChooseOption(DialogStepOption option) {
		    var d = GetDialog();
		    if(d == null) return;
		    d.OnOptionChoose.Invoke(option);
	    }
	    
	    [Button] void DemoDialog() {
	    	var d = GetDialog();
	    	var s = ShowDialogStep();
	    	Debug.Log($"{d.gameObject.name}: [{s.gameObject.name}] {s.Text}");
	    }
    }
}