using Ninject.Modules;

using BLogicLayer.Interfaces;
using BLogicLayer.Services;


namespace FlatGUI.Util
{
    public class FilmModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilmService>().To<FilmService>();
        }
    }
}
