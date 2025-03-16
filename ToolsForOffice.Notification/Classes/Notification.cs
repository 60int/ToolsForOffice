namespace ToolsForOffice.Notification.Classes
{
    public class Notification
    {
        #region Properties

        private static readonly int IntervalDefault = 1850;

        #endregion

        #region Success

        public static void ShowSuccess(string message)
        {
            ShowSuccess(message, IntervalDefault);
        }

        public static void ShowSuccess(string message, int interval)
        {
            var form = new NotificationForm();
            form.ShowNotification(message, NotificationType.Success, interval);
        }

        #endregion

        #region Information

        public static void ShowInformation(string message)
        {
            ShowInformation(message, IntervalDefault);
        }

        public static void ShowInformation(string message, int interval)
        {
            var form = new NotificationForm();
            form.ShowNotification(message, NotificationType.Information, interval);
        }

        #endregion
    }
}
