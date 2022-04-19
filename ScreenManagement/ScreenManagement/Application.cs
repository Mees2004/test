namespace ScreenManagement
{
    public class Application
    {
        public Application()
        {

        }

        public void Run()
        {
            var welcome = new Screen_1_Welcome();

            welcome.Show();
        }
    }
}