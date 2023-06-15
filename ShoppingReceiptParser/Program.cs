using Newtonsoft.Json;

string result = "";

// Read response.json file and parse its description property of the first object
using (StreamReader r = new("response.json"))
{
  string json = r.ReadToEnd();
  dynamic? array = JsonConvert.DeserializeObject(json);
  result = array is not null ? array[0].description : "Couldn't parse the data.";
}

// Print result to txt file
File.WriteAllText("output.txt", result);