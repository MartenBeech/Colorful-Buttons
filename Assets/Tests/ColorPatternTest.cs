using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class ColorPatternTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ColorPatternTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ColorPatternTestWithEnumeratorPasses()
    {
        var hsvColor = new HSVColor();
        var gameObject = new GameObject();
        var button = gameObject.AddComponent<ColorPattern>();

        Assert.AreEqual(hsvColor.Green, button.GetComponent<Image>().color);

        yield return null;
    }
}
