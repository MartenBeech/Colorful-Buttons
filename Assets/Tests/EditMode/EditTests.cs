using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class ColorPatternTest
{
    [Test]
    public void TestColorPatternNClicks()
    {
        ColorPattern colorPattern = new ColorPattern();

        Assert.AreEqual(colorPattern.nClicks, 0);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(colorPattern.nClicks, 1);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(colorPattern.nClicks, 2);
    }

    [Test]
    public void TestColorPatternTimersActivate() {
        var colorPattern = new ColorPattern();

        Assert.AreEqual(colorPattern.resetTimer, -1);
        Assert.AreEqual(colorPattern.clickTimer, -1);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(colorPattern.resetTimer, 5);
        Assert.AreEqual(colorPattern.clickTimer, 2);
    }

    [Test]
    public void TestColorPatternButtonColor() {
        var colorPattern = new ColorPattern();
        var hsvColor = new HSVColor();

        colorPattern.Start();
        GameObject gameObject = colorPattern.colorPattern;
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Green);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Blue);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Red);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Red);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Red);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(gameObject.GetComponent<Image>().color, hsvColor.Purple);
    }

    [Test]
    public void TestRandomColorButtonColor() {
        var randomColor = new RandomColor();

        randomColor.Start();
        GameObject gameObject = randomColor.randomColor;
        Assert.AreEqual(gameObject.GetComponent<Image>().color, Color.white);

        randomColor.RandomColorClicked(gameObject);
        Assert.AreNotEqual(gameObject.GetComponent<Image>().color, Color.white);
    }
}
