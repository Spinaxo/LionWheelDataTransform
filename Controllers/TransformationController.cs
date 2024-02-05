using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LionWheelDataTransform;
using LionWheelDataTransform.Controllers;
using LionWheelDataTransform.Models;

[Route("api/[controller]")]
[ApiController]
public class TransformationController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> TransformAndForward([FromBody] RequestDataModel.Welcome requestData)
    {
        try
        {
            Console.WriteLine(requestData.ToString());
            TransformedDataModel.Body transformedData = TransformationMethods.TransformData(requestData);

            var response = await SendNewRequest(transformedData);

            return Ok(response);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            return StatusCode(500, "An error occurred while processing the request.");
        }
    }




    private async Task<dynamic> SendNewRequest(TransformedDataModel.Body data)
    {
        var newRequest = BuildNewRequest(data);
        Console.WriteLine("TEST 1");
        using var client = new HttpClient();
        Console.WriteLine("TEST 2");
        var response = await client.SendAsync(newRequest);
        Console.WriteLine("TEST 3");
        var responseContent = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Response Content: {responseContent}");
        return JsonConvert.DeserializeObject(responseContent);
    }

    private HttpRequestMessage BuildNewRequest(dynamic data)
    {
        var newRequest = new HttpRequestMessage(HttpMethod.Post, "https://webhook.site/f8bdf808-54ee-41cc-afd1-d9ead9cd0f49");
        newRequest.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        return newRequest;
    }
}


