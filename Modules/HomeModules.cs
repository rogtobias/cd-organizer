using Nancy;
using System.Collections.Generic;
using CDOrganizerProject.Objects;

namespace CDOrganizerObject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml", Cd.GetAll()];
      Get["/cds/new"] = _ => View["collection_form.cshtml"];
      Post["/"] = _ => {
        Detail newDetail = new Detail(Request.Form["label"],
                                         Request.Form["genre"],
                                         Request.Form["catalogIdentification"],
                                         Request.Form["condition"],
                                         Request.Form["worth"]);
        Cd newCd = new Cd (Request.Form["artist"],
                              Request.Form["title"],
                              newDetail);
        return View["index.cshtml", Cd.GetAll()];
      };
      Post["/cds/cleared"] = _ => {
        Cd.ClearAll();
        return View["cd-cleared.cshtml"];
      };
      Get["/cds/{id}"] = parameters => {
        return View["cd-collection.cshtml", Cd.SearchCds(parameters.id)];
      };
      Post["/cds/{id}"] = parameters => {
        Cd cd = Cd.SearchCds(parameters.id);
        cd.Remove();
        List<Cd> allCds = Cd.GetAll();
        return View["index.cshtml", allCds];
      };
  }
}
}
