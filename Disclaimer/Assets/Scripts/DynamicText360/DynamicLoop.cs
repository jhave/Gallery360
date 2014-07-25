using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class DynamicLoop {

	private bool isPush;
	
	private List<string> ar_phrases360;
	private TextMesh text_360;

	public DynamicLoop(string phrases360, TextMesh text, bool push) {
		this.text_360 = text;
		this.isPush = push;
		this.ar_phrases360 = new List<string>(phrases360.Split (','));
	}

	public void pushText() {
		if (isPush) {
			text_360.text = getPhrases () + " " + text_360.text;
			int textChar = text_360.text.Length;
			int limit = 450;

			if (textChar > limit) {
				text_360.text = text_360.text.Remove(limit-1);
			}
		}
	}
	
	public string getPhrases() {
		System.Random rdnNo = new System.Random (20);
		int rdn = rdnNo.Next (0, ar_phrases360.Count);
		
		return ar_phrases360 [rdn];
	}
	
}
