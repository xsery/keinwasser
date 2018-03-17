using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CheckHudobjects {

	[Test]
	public void CheckHudobjectsSimplePasses() {
		// Use the Assert class to test conditions.
	}

	[Test]
	public void playButton()
	{
		var go = new GameObject("playButton");
		//Assert.AreEqual(playButton, go.name);

	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator CheckHudobjectsWithEnumeratorPasses() {
		
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
