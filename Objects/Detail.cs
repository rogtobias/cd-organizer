namespace CDOrganizerProject.Objects
{
  public class Detail
  {
    private string _label;
    private string _genre;
    private string _catalogIdentification;
    private string _condition;
    private decimal _worth;

    public Detail (string label, string genre, string catalogIdentification, string condition, decimal worth)
    {
      _label = label;
      _genre = genre;
      _catalogIdentification = catalogIdentification;
      _condition = condition;
      _worth = worth;
    }

    public string GetLabel()
    {
      return _label;
    }
    public void SetLabel(string label)
    {
      _label = label;
    }

    public string GetGenre()
    {
      return _genre;
    }
    public void SetGenre(string genre)
    {
      _genre = genre;
    }

    public string GetCatalogIdentification()
    {
      return _catalogIdentification;
    }
    public void SetCatalogIdentification(string catalogIdentification)
    {
      _catalogIdentification = catalogIdentification;
    }

    public string GetCondition()
    {
      return _condition;
    }
    public void SetCondition(string condition)
    {
      _condition = condition;
    }

    public decimal GetWorth()
    {
      return _worth;
    }
    public void SetWorth(decimal worth)
    {
      _worth = worth;
    }
  }
}
