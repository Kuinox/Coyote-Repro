using CK.MQTT;
using CK.MQTT.Client;
using System.Threading.Tasks;

namespace Coyote_Repro
{
    static class ApplicationMessageExtensions
    {
        public static ValueTask<Task> PublishAsync(this MQTTClientAgent @this, ApplicationMessage message)
            => @this.PublishAsync(message.Topic, message.QoS, message.Retain, message.Payload);
    }
}