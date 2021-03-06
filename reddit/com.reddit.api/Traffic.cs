﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.reddit.api
{
    public enum TrafficTimeFrame
    {
        Day,
        Hour,
        Month
    }

    public sealed class Traffic
    {
        public DateTime Date
        {
            get;
            set;
        }
        /*
        {
    "day": [
        [1314601200.0, 1, 39, 0, 0, 1, 0],
        [1314687600.0, 1, 4, 0, 0, 0, 0],
        [1314774000.0, 0, 0, 0, 0, 0, 0],
        [1314860400.0, 0, 0, 0, 0, 0, 0],
        [1314946800.0, 0, 0, 0, 0, 0, 0],
        [1315033200.0, 0, 0, 0, 0, 0, 0],
        [1315119600.0, 0, 0, 0, 0, 0, 0],
        [1315206000.0, 0, 0, 0, 0, 0, 0],
        [1315292400.0, 0, 0, 0, 0, 0, 0],
        [1315378800.0, 0, 0, 0, 0, 0, 0],
        [1315465200.0, 0, 0, 0, 0, 0, 0],
        [1315551600.0, 0, 0, 0, 0, 0, 0],
        [1315638000.0, 0, 0, 0, 0, 0, 0],
        [1315724400.0, 0, 0, 0, 0, 0, 0],
        [1315810800.0, 0, 0, 0, 0, 0, 0],
        [1315897200.0, 0, 0, 0, 0, 0, 0],
        [1315983600.0, 0, 0, 0, 0, 0, 0],
        [1316070000.0, 0, 0, 0, 0, 0, 0],
        [1316156400.0, 0, 0, 0, 0, 0, 0],
        [1316242800.0, 0, 0, 0, 0, 0, 0],
        [1316329200.0, 0, 0, 0, 0, 0, 0],
        [1316415600.0, 0, 0, 0, 0, 0, 0],
        [1316502000.0, 0, 0, 0, 0, 0, 0],
        [1316588400.0, 0, 0, 0, 0, 0, 0],
        [1316674800.0, 0, 0, 0, 0, 0, 0],
        [1316761200.0, 0, 0, 0, 0, 0, 0],
        [1316847600.0, 0, 0, 0, 0, 0, 0],
        [1316934000.0, 0, 0, 0, 0, 0, 0],
        [1317020400.0, 0, 0, 0, 0, 0, 0],
        [1317106800.0, 0, 0, 0, 0, 0, 0],
        [1317193200.0, 0, 0, 0, 0, 0, 0],
        [1317279600.0, 0, 0, 0, 0, 0, 0],
        [1317366000.0, 0, 0, 0, 0, 0, 0],
        [1317452400.0, 0, 0, 0, 0, 0, 0],
        [1317538800.0, 0, 0, 0, 0, 0, 0],
        [1317625200.0, 0, 0, 0, 0, 0, 0],
        [1317711600.0, 0, 0, 0, 0, 0, 0],
        [1317798000.0, 0, 0, 0, 0, 0, 0],
        [1317884400.0, 0, 0, 0, 0, 1, 0]
    ],
    "hour": [
        [1314633600.0, 1, 21, 0, 0],
        [1314637200.0, 1, 13, 0, 0],
        [1314640800.0, 0, 0, 0, 0],
        [1314644400.0, 0, 0, 0, 0],
        [1314648000.0, 1, 5, 0, 0],
        [1314651600.0, 0, 0, 0, 0],
        [1314655200.0, 0, 0, 0, 0],
        [1314658800.0, 0, 0, 0, 0],
        [1314662400.0, 0, 0, 0, 0],
        [1314666000.0, 0, 0, 0, 0],
        [1314669600.0, 0, 0, 0, 0],
        [1314673200.0, 0, 0, 0, 0],
        [1314676800.0, 0, 0, 0, 0],
        [1314680400.0, 0, 0, 0, 0],
        [1314684000.0, 0, 0, 0, 0],
        [1314687600.0, 0, 0, 0, 0],
        [1314691200.0, 0, 0, 0, 0],
        [1314694800.0, 0, 0, 0, 0],
        [1314698400.0, 0, 0, 0, 0],
        [1314702000.0, 0, 0, 0, 0],
        [1314705600.0, 0, 0, 0, 0],
        [1314709200.0, 0, 0, 0, 0],
        [1314712800.0, 1, 4, 0, 0]
    ],
    "month": [
        [1312182000.0, 2, 43, 0, 0]
    ]
}
        */
    }
}
