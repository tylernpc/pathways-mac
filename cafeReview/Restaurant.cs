/*
string Name { get; set; }
string Cuisine { get; set; }
string Rating { get; set; }
*/
using System;

class Restaurant
{
    // getters and setters 
    public string RestaurantName { get; set; }
    public string CuisineType { get; set; }
    public int TotalRating { get; set; }

    // default class constructor
    public Restaurant()
    {
        RestaurantName = "undefined";
        CuisineType = "undefined";
        TotalRating = 0;
    }

    // user information that gets passed
    public Restaurant(string restaurantName, string cuisineType, int totalRating)
    {
        this.RestaurantName = restaurantName;
        this.CuisineType = cuisineType;
        this.TotalRating = totalRating;
    }

    // override for default return string
    public override string ToString()
    {
        return ($"Restaurant Name: {RestaurantName} | Cuisine Type: {CuisineType} | Rating: {TotalRating} Stars");
    }
}