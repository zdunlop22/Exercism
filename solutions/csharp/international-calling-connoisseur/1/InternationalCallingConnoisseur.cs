public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return (new Dictionary<int, string>());
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
       Dictionary<int, string> populatedDictionary = new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"},
        };

        return populatedDictionary;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var emptyDict = new Dictionary<int, string>();
        emptyDict.Add(countryCode, countryName);
        return emptyDict;
        
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        try
        {
            return existingDictionary[countryCode];
        }
        catch (KeyNotFoundException)
        {
            return "";
        }
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
        {
            existingDictionary[countryCode]=countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestValue="";
        foreach (var value in existingDictionary.Values)
        {
            if (value != null && value.Length > longestValue.Length)
            {
                longestValue = value;
            }
        }
        return longestValue;
    }
}