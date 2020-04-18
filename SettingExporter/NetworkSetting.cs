using DataType;
using System;
using System.Collections.Generic;
using System.Text;

namespace SettingExporter
{
    public class NetworkSetting
    {
        public IpAddressDataType SrcAddress { get; set; }
        public IntDataType SrcPort { get; set; }
        public IpAddressDataType DstAddress { get; set; }
        public IntDataType DstPort { get; set; }

        public NetworkSetting()
        {
            SrcAddress = new IpAddressDataType()
            {
                Hint = "ex: 127.0.0.1"
            };
            SrcPort = new IntDataType()
            {
                Validate = (value) => { return 0 <= value && value <= 65536; },
                Hint = "0 - 65536"
            };
            DstAddress = new IpAddressDataType()
            {
                Hint = "ex: 127.0.0.1"
            };
            DstPort = new IntDataType()
            {
                Validate = (value) => { return 0 <= value && value <= 65536; },
                Hint = "0 - 65536"
            };
        }

    }
}
