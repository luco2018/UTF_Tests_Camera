using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CullingCheck : MonoBehaviour {

    public TextMesh _text;

    public Renderer[] rends;
	public Renderer[] visibleRends;
    public bool passed;

    IEnumerator Start () {
        yield return new WaitForEndOfFrame();

        passed = true;
        foreach(Renderer rend in rends)
		{
			if(rend.isVisible)
                passed = false;
        }
		foreach (Renderer visibleRend in visibleRends)
        {
            if (!visibleRend.isVisible)
                passed = false;
        }

		if(passed)
		{
            //do passed
            _text.color = Color.green;
            _text.text = "PASS";
        }
		else
		{
            //do failed
            _text.color = Color.red;
            _text.text = "FAIL";
        }
	}
}
