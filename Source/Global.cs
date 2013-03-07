﻿using System;
using System.ComponentModel;

namespace snorbert
{
    /// <summary>
    /// 
    /// </summary>
    public class Global
    {
        #region Event Delegates
        public delegate void MessageEvent(string message);
        public delegate void DefaultEvent();
        #endregion

        #region Constants
        public const string PRIORITIES_FILE = "Priorities.txt";
        public const string RULES_DB = "Rules.db";
        #endregion

        #region Enums
        /// <summary>
        /// 
        /// </summary>
        public enum Protocols : int
        {
            [Description("ICMP")]
            Icmp = 1,
            [Description("TCP")]
            Tcp = 6,
            [Description("UDP")]
            Udp = 17
        }

        [Flags]
        public enum TcpFlags
        {
            [Description("FIN")]
            FIN = 0x01,
            [Description("SYN")]
            SYN = 0x02,
            [Description("RST")]
            RST = 0x04,
            [Description("PSH")]
            PSH = 0x08,
            [Description("ACK")]
            ACK = 0x10,
            [Description("URG")]
            URG = 0x20,
            [Description("ECE")]
            ECE = 0x40,
            [Description("CWR")]
            CWR = 0x80,
            [Description("NS")]
            NS = 0x160
        }

        /// <summary>
        /// 
        /// </summary>
        public enum FieldsEvent : int
        {
            Cid = 0,
            SrcIp = 1,
            SrcPort = 2,
            DstIp = 3,
            DstPort = 4,
            Protocol = 5,
            Host = 6,
            Timestamp = 7,
            TcpFlags = 8,
            Payload = 9
        }

        /// <summary>
        /// 
        /// </summary>
        public enum FieldsEventCopy : int
        {
            Cid = 0,
            Sid = 1,
            SrcIp = 2,
            SrcPort = 3,
            DstIp = 4,
            DstPort = 5,
            SigName = 6,
            Timestamp = 7,
            PayloadAscii = 8,
            HttpHost = 9
        }

        /// <summary>
        /// 
        /// </summary>
        public enum FieldsReferences : int
        {
            Type = 0,
            Data = 1
        }

        /// <summary>
        /// 
        /// </summary>
        public enum FilterType
        {
            Numeric = 0,
            Text = 1,
            Ip = 2,
            Timestamp = 3,
            Severity = 4,
            //SignatureName = 5,
            //SignatureId = 6,
            Classification = 5,
            PayloadAscii = 6,
            PayloadHex = 7,
            Sensor = 8,
            Protocol = 9
        }
        #endregion
    }
}
