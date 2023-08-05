using System.Collections.Generic;

[System.Serializable]
public class Schema
{
    [System.Serializable]
    public class ApiResponse
    {
        public Info info;
        public List<Character> results;
    }

    [System.Serializable]
    public class Info
    {
        public int count;
        public int pages;
        public string next;
        public string prev;
    }

    [System.Serializable]
    public class Character
    {
        public int id;
        public string name;
        public string status;
        public string species;
        public string image;
        // Otros campos de datos según la API de Rick and Morty
    }
}