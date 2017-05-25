using System.Collections.Generic;

namespace CDOrganizerProject.Objects
{
  public class Cd
  {
    private string _artist;
    private string _title;
    private int _id;
    private Detail _detailInfo;
    private static List<Cd> _instances = new List<Cd> {};

    public Cd(string artist, string title, Detail detailInfo)
    {
      _artist = artist;
      _title = title;
      _detailInfo = detailInfo;
      _id = _instances.Count;

      _instances.Add(this);
    }

    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string artist)
    {
      _artist = artist;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string title)
    {
      _title = title;
    }
    public int GetId()
    {
      return _id;
    }

    public Detail GetDetailInfo()
    {
      return _detailInfo;
    }
    public void SetDetailInfo(Detail newDetailInfo)
    {
      _detailInfo = newDetailInfo;
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Cd SearchCds(int searchId)
    {
      return _instances[searchId];
    }
    public void Remove()
    {
      _instances.Remove(this);
    }

  }
}
