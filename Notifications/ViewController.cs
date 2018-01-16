using System;
using Foundation;
using UIKit;

namespace Notifications
{
    public partial class ViewController : UIViewController
    {


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();




            button.TouchUpInside += (sender, e) =>
                {
                    var msg = "Locker Number: " + LockerNumberTxtView.Text + " Locker Combination: " + LockerCombinationTxtView.Text;
                    // create the notification
                    var notification = new UILocalNotification();

                    // set the fire date (the date time in which it will fire)
                    notification.FireDate = NSDate.FromTimeIntervalSinceNow(5);

                    // configure the alert
                    notification.AlertAction = "View Saved Info";
                    notification.AlertBody = msg;

                    // modify the badge
                    notification.ApplicationIconBadgeNumber = 1;

                    // set the sound to be the default sound
                    notification.SoundName = UILocalNotification.DefaultSoundName;

                    // schedule it
                    UIApplication.SharedApplication.ScheduleLocalNotification(notification);
                    Console.WriteLine("Scheduled...");
                };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

