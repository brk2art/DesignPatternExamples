namespace FrontControllerPattern
{
    public class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void dispatch(string request)
        {
            if (request.Equals("STUDENT"))
            {
                studentView.show();
            }
            else
            {
                homeView.show();
            }
        }
    }
}
