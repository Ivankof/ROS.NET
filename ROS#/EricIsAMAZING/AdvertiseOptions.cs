﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EricIsAMAZING
{
    public class AdvertiseOptions : StuffOptions
    {
        public bool latch = false, has_header;
        public string topic, md5sum, datatype, message_definition;
        public MulticastDelegate connectCB, disconnectCB;
        public AdvertiseOptions()
        {
        }

        public AdvertiseOptions(string t, int q_size, string md5, string dt, string message_def, MulticastDelegate connectcallback = null, MulticastDelegate disconnectcallback = null)
        {
            topic = t;
            queue_size = q_size;
            md5sum = md5;
            datatype = dt;
            message_definition = message_def;
            connectCB = connectcallback;
            disconnectCB = disconnectcallback;
        }

        public AdvertiseOptions(string t, int q_size, MulticastDelegate connectcallback = null, MulticastDelegate disconnectcallback = null) :
            this(t, q_size, "", "", "", connectcallback, disconnectcallback)
        {
        }

        public static AdvertiseOptions Create(string topic, int q_size, MulticastDelegate connectcallback, MulticastDelegate disconnectcallback, CallbackQueue queue)
        {
            return new AdvertiseOptions(topic, q_size, connectcallback, disconnectcallback) { callbackQueue = queue };
        }
    }
}