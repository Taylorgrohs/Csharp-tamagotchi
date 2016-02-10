using Nancy;
using Tamagotchis.Objects;
using System.Collections.Generic;

namespace Tamagotchis
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/tamagotchis"] = _ => {
        List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
        return View["tamagotchis.cshtml", allTamagotchis];
      };
      Get["/tamagotchis/new"] = _ => {
        return View["tamagotchi_form.cshtml"];
      };
      Post["/tamagotchis"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["new-name"]);
        List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
        return View["tamagotchis.cshtml", allTamagotchis];
      };
      Post["/tamagotchis_time"] = _ => {
        List<Tamagotchi> time = Tamagotchi.Time();
        return View["tamagotchis.cshtml", time];
      };
    }
  }
}
