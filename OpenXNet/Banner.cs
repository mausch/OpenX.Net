using CookComputing.XmlRpc;

namespace OpenXNet {
    public class Banner {
        [XmlRpcMember("campaignId")]
        public int CampaignId { get; set; }
    }
}