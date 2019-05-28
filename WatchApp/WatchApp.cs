namespace WatchApp
{
    public class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        public static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            global::Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init();
            app.Run(args);
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            var consumer = new DataConsumer();
            consumer.DataChangeListen();

            LoadApplication(new App());
        }
    }
}
