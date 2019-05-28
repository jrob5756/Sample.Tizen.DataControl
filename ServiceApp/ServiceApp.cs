using Tizen.Applications;

namespace ServiceApp
{
    public class App : ServiceApplication
    {
        public static void Main(string[] args)
        {
            var app = new App();
            app.Run(args);
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            var dataProvider = new DataProvider();
            dataProvider.Run();
        }
    }
}
