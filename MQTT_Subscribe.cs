using NLog;
using QRCoder;
using System.Data;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
//code windows packages:
using uPLibrary.Networking.M2Mqtt.Messages;

namespace FYP_Alert_Server
{
    public class MQTT_Subscribe
    {
        private static MqttClient client;
        private Logger log = LogManager.GetCurrentClassLogger();
        private int MQTT_Counter = 0;
        public void InitializeMqttConnection()
        {

            string brokerAddress = "192.168.0.107";
            int brokerPort = 1883; // Default MQTT port
            string clientId = Guid.NewGuid().ToString();

            client = new MqttClient(brokerAddress, brokerPort, false, null, null, MqttSslProtocols.None);

            // Handle message received event
            client.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;

            // Connect to MQTT broker
            client.Connect(clientId, "mqtt", "willcheney");

            // Subscribe to the "Distance" topic
            client.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        public void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string message = Encoding.Default.GetString(e.Message);

            // Display the received message in a message box
            log.Debug($"Received message on topic '{topic}': {message}");

            //Counter for Messages passing through MQTT
            MQTT_Counter++;

        }
        public int GetMQTTCounter()
        {
            return MQTT_Counter;
            
        }

        public void btnRetrieveMessage_Click(object sender, EventArgs e)
        {
            // You can use this button's click event to retrieve the MQTT message
            // This event will display the received message in a message box
        }
    }


    
}
