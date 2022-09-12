﻿using System.Collections.ObjectModel;
using LabWork_MAUI_App.sln.Model;
using LabWork_MAUI_App.sln.Services;

namespace LabWork_MAUI_App.sln.ViewModel;

public class CountryViewModel : BindableObject
{
    private Country _selectedCountry;
    private Food _selectedFood;

    CountryService countryService = new ();

    public ObservableCollection<Food> Foods { get; } = new();

    public ObservableCollection<Country> Countries { get; } = new();

    public CountryViewModel()
    {
        GetCountryAsync();
    }

    public string Desc { get; set; }
    public string FoodDesc { get; set; }

    public Country SelectedCountry
    {
        get => _selectedCountry;
        set
        {
            _selectedCountry = value;
            Desc = value?.Description;
            OnPropertyChanged(nameof(Desc));
            GetFoodAsync();
        }
    }

    public Food SelectedFood
    {
        get => _selectedFood;
        set
        {
            _selectedFood = value;
            FoodDesc = value?.Description;
            OnPropertyChanged(nameof(FoodDesc));
        }
    }

    async Task GetFoodAsync()
    {
        try
        {
            IEnumerable<Food> foods = new List<Food>();

            if (Foods.Count != 0)
                Foods.Clear();
            if (SelectedCountry.Food == null) return;
            foreach (var food in SelectedCountry.Food)
            {
                Foods.Add(food);
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Ошибка", $"Что то пошло не так: {ex.Message}", "ОК");
        }
    }
    async Task GetCountryAsync()
    {
        try
        {
            var countries = await countryService.GetCountry();

            if (Countries.Count != 0)
                Countries.Clear();
            foreach (var country in countries)
            {
                Countries.Add(country);
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Ошибка", $"Что то пошло не так: {ex.Message}", "ОК");
        }
    }
}