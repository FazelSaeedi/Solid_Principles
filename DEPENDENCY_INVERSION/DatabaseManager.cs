namespace Solid_Principles.DEPENDENCY_INVERSION
{
    public class DatabaseManager
        {

            public INotification notification ;

            public DatabaseManager(INotification notification)
            {
                this.notification = notification;
            }

            public void Add()
            {
                notification.Send("Add New Record");
            }

            public void Remove()
            {
                notification.Send("Update");
            }

            public void Update()
            {
                notification.Send("Remove");
            }
        }

    
}