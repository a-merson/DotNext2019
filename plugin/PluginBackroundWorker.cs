using System;
using System.Collections.Generic;
using System.Text;
using Abp;
using Abp.Dependency;
using Abp.Notifications;
using Abp.Threading;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;

namespace Plugin
{
    public class PluginBackgroundWorker : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly INotificationPublisher _notificationPublisher;

        public PluginBackgroundWorker(AbpTimer timer, INotificationPublisher notificationPublisher) 
            : base(timer)
        {
            _notificationPublisher = notificationPublisher;
            Timer.Period = 10000;
        }

        protected override void DoWork()
        {
			Console.WriteLine("Sending notification");
            AsyncHelper.RunSync(() => _notificationPublisher.PublishAsync(
                                    "HelloDotNextNotification",
                                    data: new MessageNotificationData("Hello DotNext!"),
                                    severity: NotificationSeverity.Success,
                                    userIds: new[] { new UserIdentifier(2, 4), }));
        }
    }
}
