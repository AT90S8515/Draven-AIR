﻿using RtmpSharp.IO;
using RtmpSharp.IO.AMF3;
using System;
using System.Collections.Generic;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.TalentGroup")]
    public class TalentGroup
    {
        [SerializedName("index")]
        public Int32 Index { get; set; }
        [SerializedName("talentRows")]
        public ArrayCollection TalentRows { get; set; }
        [SerializedName("name")]
        public String Name { get; set; }
        [SerializedName("tltGroupId")]
        public Int32 TltGroupId { get; set; }
        [SerializedName("version")]
        public Int32 Version { get; set; }
    }
}
