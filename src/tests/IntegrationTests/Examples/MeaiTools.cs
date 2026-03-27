/*
order: 20
title: MEAI Tools
slug: meai-tools

Shows how to use Roboflow as AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Roboflow.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsObjectDetectionTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an object detection tool from the Roboflow client for use with any IChatClient.
        var tool = client.AsObjectDetectionTool(confidence: 0.5);
        tool.Name.Should().Be("DetectObjects");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsClassificationTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a classification tool from the Roboflow client for use with any IChatClient.
        var tool = client.AsClassificationTool(confidence: 0.5);
        tool.Name.Should().Be("ClassifyImage");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsOcrTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an OCR tool from the Roboflow client for use with any IChatClient.
        var tool = client.AsOcrTool();
        tool.Name.Should().Be("ExtractTextFromImage");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsInstanceSegmentationTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an instance segmentation tool from the Roboflow client for use with any IChatClient.
        var tool = client.AsInstanceSegmentationTool(confidence: 0.5);
        tool.Name.Should().Be("SegmentObjects");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
