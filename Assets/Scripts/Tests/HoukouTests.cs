using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HoukouTests
{
    [Test]
    public void HoukouTestsSimplePasses()
    {
        var hou = new Houkou();
        Assert.That(hou.GetLimitedDegree(0), Is.EqualTo(6).Within(0.001f), "0�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(11.9f), Is.EqualTo(6).Within(0.001f), "11.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(12f), Is.EqualTo(18).Within(0.001f), "12�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(23.9f), Is.EqualTo(18).Within(0.001f), "23.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(24f), Is.EqualTo(30).Within(0.001f), "24�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(179.9f), Is.EqualTo(174).Within(0.001f), "179.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(180f), Is.EqualTo(186).Within(0.001f), "180�x�`�F�b�N");

        Assert.That(hou.GetLimitedDegree(-0), Is.EqualTo(6).Within(0.001f), "-0�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-0.001f), Is.EqualTo(-6).Within(0.001f), "-0.001�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-11.9f), Is.EqualTo(-6).Within(0.001f), "-11.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-12f), Is.EqualTo(-18).Within(0.001f), "-12�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-23.9f), Is.EqualTo(-18).Within(0.001f), "-23.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-24f), Is.EqualTo(-30).Within(0.001f), "-24�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-179.9f), Is.EqualTo(-174).Within(0.001f), "-179.9�x�`�F�b�N");
        Assert.That(hou.GetLimitedDegree(-180f), Is.EqualTo(-186).Within(0.001f), "-180�x�`�F�b�N");

    }
}
