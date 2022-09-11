using System.Text.Json;
using LabWork_MAUI_App.sln.Model;

namespace LabWork_MAUI_App.sln.Services;

public class FoodService
{
    private List<Food> _foodList = new List<Food>();

    public async Task<IEnumerable<Food>> GetFood()
    {
        if(_foodList.Count > 0)
            return _foodList;

        await using var stream = await FileSystem.OpenAppPackageFileAsync("Food.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        _foodList = JsonSerializer.Deserialize<List<Food>>(contents);

        return _foodList;
    }
}