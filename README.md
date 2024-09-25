# UDP Flooding Script (DoS Demonstration)

## Overview

This script demonstrates the concept of a basic **Denial of Service (DoS)** attack by repeatedly sending UDP packets to a target IP address and port. This script is intended solely for **educational purposes** to show how a rudimentary DoS attack might function, and should **not** be used for malicious or illegal activities.

## Disclaimer

This script is provided **only for learning and ethical hacking** purposes. Unauthorized usage of this tool to attack systems you do not own or have explicit permission to test is **illegal** and may lead to severe consequences. Always ensure you have proper consent from the target system's owner before conducting any tests.

### Important Notices:
1. **This script cannot be licensed**: The script is open and cannot be licensed under any formal license terms. No warranty or guarantees are provided for its functionality or behavior.
2. **User assumes all responsibility**: By downloading, modifying, or using this script, the user assumes full responsibility for any actions taken using this code. The author is not liable for any damages or consequences resulting from its use.

## How It Works

The script sends "Hello" UDP packets to a specific IP address and port repeatedly. This behavior mimics a simple UDP flood attack, where excessive traffic is sent to the target in an attempt to overwhelm the service, though the current configuration is quite low intensity.

- **Target IP**: The IP address of the machine you want to send UDP packets to.
- **Target Port**: The port number on which the target machine listens for UDP traffic.
- **UDP Packet**: A small message (in this case, "Hello") sent repeatedly to the target.

## Usage

1. **Pre-requisites**: Make sure you have `dotnet` or a compatible C# runtime installed on your system to run the script.

2. **Configure Target**:
   - Update the `targetIp` and `targetPort` variables in the script with the correct values. For example:
     ```csharp
     string targetIp = "192.168.1.100"; // Replace with your target's IP address
     int targetPort = 80;               // Replace with the correct port
     ```

3. **Run the Script**:
   - Open this project in Visual Studio 17
   - Compile and run the program.
   - The script will begin sending UDP packets to the target in an infinite loop, sending 100 packets every 15 seconds.

## Example Output

When the script is running, it will send 3 UDP packets every 15 seconds and print the following message to the console:

```
Data sent on 192.168.1.100:80
Data sent on 192.168.1.100:80
Data sent on 192.168.1.100:80
```

## Warning

- **Do not** run this script against any system you do not have explicit permission to test.
- Running the script against unauthorized targets is a violation of the law in most jurisdictions and could lead to legal consequences.

## Educational Use Only

This project is strictly for learning and ethical purposes. It aims to illustrate the potential risks and vulnerabilities associated with insufficiently secured networks or services. Responsible usage and adherence to ethical guidelines are mandatory when experimenting with network security tools.
