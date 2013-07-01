using Nancy;

namespace PlazaVillage.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
                {
                    ViewBag.Title = "Plaza Village Condominiums";
                    return View["index"];
                };
        }
    }
}