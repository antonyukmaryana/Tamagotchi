using System.Collections.Generic;
namespace Tamagotchi.Models
{
    public class Tamagotchi
    {
        private string  _name;
         private int _id;

        private int _food;
        private int _attention;
        private int _rest;
        private static List<Tamagotchi> _instances = new List<Tamagotchi>{};
        public Tamagotchi (string name, int food, int attention, int rest){
          _name = name;
          _food = food;
          _attention = attention;
          _rest = rest;
          _instances.Add(this);
          _id = _instances.Count;

        }
        public string GetName()
        {
            return _name;
        }
        public void SetName (string newName)
        {
            _name = newName;
        }
        public int GetFood()
        {
            return _food;
        }
        public void SetFood(int food)
        {
            _food = food;
        }
        public int GetAttention()
        {
            return _attention;
        }
        public void SetAttention(int attention)
        {
            _attention = attention;
        }
        public int GetRest()
        {
            return _rest;
        }
        public void SetRest(int rest)
        {
            _rest = rest;
        }
        public static List<Tamagotchi> GetAll()
        {
        return _instances;
        }

        public static void ClearAll()
        {
        _instances.Clear();
        }
        public int GetId()
        {
            return _id;
        }
        public static Tamagotchi Find(int searchId)
        {
            return _instances[searchId-1];
        }
    }
}