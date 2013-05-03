//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux products: http://www.gurux.org
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Gurux.DLMS;



using System.Xml.Serialization;
using Gurux.DLMS.ManufacturerSettings;

namespace Gurux.DLMS.Objects
{
    public class GXDLMSHdlcSetup : GXDLMSObject
    {
        /// <summary> 
        /// Constructor.
        /// </summary> 
        public GXDLMSHdlcSetup()
            : base(ObjectType.IecHdlcSetup)
        {
            CommunicationSpeed = 5;
            WindowSizeReceive = WindowSizeTransmit = 1;
            MaximumInfoLengthTransmit = MaximumInfoLengthReceive = 128;
        }

        /// <summary> 
        /// Constructor.
        /// </summary> 
        /// <param name="ln">Logican Name of the object.</param>
        public GXDLMSHdlcSetup(string ln)
            : base(ObjectType.IecHdlcSetup, ln, 0)
        {
        }

        /// <summary> 
        /// Constructor.
        /// </summary> 
        /// <param name="ln">Logican Name of the object.</param>
        /// <param name="sn">Short Name of the object.</param>
        public GXDLMSHdlcSetup(string ln, ushort sn)
            : base(ObjectType.IecHdlcSetup, ln, 0)
        {
        }

        /// <inheritdoc cref="GXDLMSObject.UpdateDefaultValueItems"/>
        public override void UpdateDefaultValueItems()
        {
            GXDLMSAttributeSettings att = this.Attributes.Find(2);
            if (att == null)
            {
                att = new GXDLMSAttribute(2);
                Attributes.Add(att);
            } 
            att.Values.Add(new GXObisValueItem(0, "300"));
            att.Values.Add(new GXObisValueItem(1, "600"));
            att.Values.Add(new GXObisValueItem(2, "1200"));
            att.Values.Add(new GXObisValueItem(3, "2400"));
            att.Values.Add(new GXObisValueItem(4, "4800"));
            att.Values.Add(new GXObisValueItem(5, "9600"));
            att.Values.Add(new GXObisValueItem(6, "19200"));
            att.Values.Add(new GXObisValueItem(7, "38400"));
            att.Values.Add(new GXObisValueItem(8, "57600"));
            att.Values.Add(new GXObisValueItem(9, "115200"));         
        }

        [XmlIgnore()]
        [GXDLMSAttribute(2)]
        public int CommunicationSpeed
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(1)]
        [GXDLMSAttribute(3)]
        public int WindowSizeTransmit
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(1)]
        [GXDLMSAttribute(4)]
        public int WindowSizeReceive
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(128)]
        [GXDLMSAttribute(5)]
        public int MaximumInfoLengthTransmit
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(128)]
        [GXDLMSAttribute(6)]
        public int MaximumInfoLengthReceive
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(30)]
        [GXDLMSAttribute(7)]
        public int InterCharachterTimeout
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(120)]
        [GXDLMSAttribute(8)]
        public int InactivityTimeout
        {
            get;
            set;
        }

        [XmlIgnore()]
        [DefaultValue(0)]
        [GXDLMSAttribute(9)]
        public int DeviceAddress
        {
            get;
            set;
        }

        public override object[] GetValues()
        {
            return new object[] { LogicalName, CommunicationSpeed, WindowSizeTransmit, WindowSizeReceive, MaximumInfoLengthTransmit, MaximumInfoLengthReceive, InterCharachterTimeout, InactivityTimeout, DeviceAddress };
        }
    }
}