using System.Collections.Generic;

namespace Tamagotchis.Objects
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _sleep;
    private static List<Tamagotchi> _tamagotchiList = new List<Tamagotchi> {};
    // Constructor
    public Tamagotchi(string name)
    {
      _name = name;
      _food = 100;
      _attention = 100;
      _sleep = 100;
      _tamagotchiList.Add(this);
    }
    // Getters and Setters
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }
    // List all method
    public static List<Tamagotchi> GetAll()
    {
      return _tamagotchiList;
    }
    // Feed method
    public int Feed()
    {
      if(_food < 100)
      {
        _food = _food + 5;
        return _food;
      }
      else
      {
        return _food;
      }
    }
    // Attention method
    public int Attention()
    {
      if(_attention < 100)
      {
        _attention = _attention + 5;
        return _attention;
      }
      else
      {
        return _attention;
      }
    }
    // Sleep method
    public int Sleep()
    {
      if(_sleep < 100)
      {
        _sleep = _sleep + 5;
        return _sleep;
      }
      else
      {
        return _sleep;
      }
    }
    // Subtract "time" method
    public static List<Tamagotchi> Time()
    {
      foreach(Tamagotchi i in _tamagotchiList)
      {

        i._food = i._food - 10;
        i._attention = i._attention - 10;
        i._sleep = i._sleep - 10;
      }
      return _tamagotchiList;
    }

  }
}
