using System;
using CookComputing.XmlRpc;

namespace OpenXNet {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class Campaign {
        [XmlRpcMember("campaignId")]
        public int Id { get; set; }

        [XmlRpcMember("campaignName")]
        public string CampaignName { get; set; }

        [XmlRpcMember("advertiserId")]
        public int AdvertiserId { get; set; }

        /// <summary>
        /// Frequency capping: reset period, in seconds.
        /// </summary>
        [XmlRpcMember("block")]
        public int Block { get; set; }

        /// <summary>
        /// Frequency capping: total views per user.
        /// </summary>
        [XmlRpcMember("capping")]
        public int Capping { get; set; }

        /// <summary>
        /// Number of clicks booked for the campaign.
        /// </summary>
        [XmlRpcMember("clicks")]
        public int Clicks { get; set; }

        [XmlRpcMember("comments")]
        public string Comments { get; set; }

        [XmlRpcMember("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Number of impressions booked for the campaign.
        /// </summary>
        [XmlRpcMember("impressions")]
        public int Impressions { get; set; }

        [XmlRpcMember("priority")]
        public int Priority { get; set; }

        [XmlRpcMember("revenue")]
        public decimal Revenue { get; set; }

        [XmlRpcMember("revenueType")]
        public int RevenueType { get; set; }

        /// <summary>
        /// Frequency capping: total views per period
        /// </summary>
        [XmlRpcMember("sessionCapping")]
        public int SessionCapping { get; set; }

        [XmlRpcMember("startDate")]
        public DateTime StartDate { get; set; }

        [XmlRpcMember("targetClicks")]
        public int TargetClicks { get; set; }

        [XmlRpcMember("targetConversions")]
        public int TargetConversions { get; set; }

        [XmlRpcMember("targetImpressions")]
        public int TargetImpressions { get; set; }

        [XmlRpcMember("weight")]
        public int Weight { get; set; }

    }
}