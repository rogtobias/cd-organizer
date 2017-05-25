using System.Collections.Generic;

namespace CDOrganizerProject.Objects
{
  public class Cds
  {
    private string _artist;
    private string _title;
    private string _label;
    private string _genre;
    private string _catalogId;
    private string _condition;
    private float _worth;
    private int _id;
    private static List<Cds> _cds = new List<Cds> {};

    public Cds(string artist, string title, string label, string genre, string catalogId, string condition, float worth)
    {
      _artist = artist;
      _title = title;
      _label = label;
      _genre = genre;
      _catalogNumber = catalogId;
      _condition = condition;
      _worth = worth;
      _id = cds.Count;
    }

    public static List<Cds> GetAll()
    {
      return _cds;
    }

    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist()
    {
      _artist = artist;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle()
    {
      _title = title;
    }

    public string GetLabel()
    {
      return _label;
    }
    public void SetLabel()
    {
      _label = label;
    }

    public string GetGenre()
    {
      return _genre;
    }
    public void SetGenre()
    {
      _genre = genre;
    }

    public string GetCatalogId()
    {
      return _catalogId
    }
    public void SetCatalogId()
    {
      _catalogId = catalogId;
    }

    public string GetCondition()
    {
      return _condition;
    }
    public void SetCondition()
    {
      _condition = condition;
    }

    public float GetWorth()
    {
      return _value;
    }
    public void SetWorth()
    {
      _worth = worth;
    }

    public int GetId()
    {
      return _id
    }

  }
}
