using HomeWork_25;
using Newtonsoft.Json;
using System.Text;

var company1 = new Company
{
    Name = "Apple",
    Address = "Californiya",
    Email = "apple@icloud.com",
    Phone = "***********",
};

var company2 = new Company
{
    Name = "Samsung",
    Address = "Korea",
    Email = "samsung@gmail.com",
    Phone = "&*&&&&&",
};

//#region Post Get  
//var json = JsonConvert.SerializeObject(company1);
//var data = new StringContent(json, Encoding.UTF8, "application/json");
//var url = "http://localhost:5258/api/Companies/";
//using var client = new HttpClient();

////Create
//var response = await client.PostAsync(url, data);
//var result = await response.Content.ReadAsStringAsync();
//Console.WriteLine(result);

////Get
//response = await client.GetAsync(url);
//result = await response.Content.ReadAsStringAsync();
//Console.WriteLine(result);
//#endregion Post Get

#region Update Delete
var json1 = JsonConvert.SerializeObject(company2);
var data = new StringContent(json1, Encoding.UTF8, "application/json");
using var client = new HttpClient();

string id = Console.ReadLine();
Guid guId = Guid.Parse(id);

var url = $"http://localhost:5258/api/Companies?id={guId}";

//Update
var putResponse = await client.PutAsync(url, data);
var putResult = await putResponse.Content.ReadAsStringAsync();
Console.WriteLine(putResult);


////Delete
//var response = await client.DeleteAsync(url);
//var deleteResult = await response.Content.ReadAsStringAsync();
//Console.WriteLine(deleteResult);
#endregion Update Delete