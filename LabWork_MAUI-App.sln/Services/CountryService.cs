using System.Text.Json;
using LabWork_MAUI_App.sln.Model;

namespace LabWork_MAUI_App.sln.Services;

public class CountryService
{
    List<Country> _countryList = new();

    public async Task<IEnumerable<Country>> GetCountry()
    {
        if (_countryList.Count > 0)
            return _countryList;

        await using var stream = await FileSystem.OpenAppPackageFileAsync("Country.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        _countryList = JsonSerializer.Deserialize<List<Country>>(contents);

        return _countryList;
    }
}