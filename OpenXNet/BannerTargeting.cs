using CookComputing.XmlRpc;

namespace OpenXNet {
    public class BannerTargeting {
        /// <summary>
        /// Logical operator: 'and' or 'or'
        /// </summary>
        [XmlRpcMember("logical")]
        public string Logical { get; set; }

        /// <summary>
        /// Which targeting plugin this rule uses.
        /// e.g. 'Site:Pageurl'
        /// </summary>
        [XmlRpcMember("type")]
        public string Type { get; set; }

        /// <summary>
        /// Which operation to apply to the data in order to determine if a rule passes or fails.
        /// e.g. '==', '!='
        /// </summary>
        [XmlRpcMember("comparison")]
        public string Comparison { get; set; }

        /// <summary>
        /// Actual data to be targeted. Since this is specific to the individual plugin it is fairly free-form.
        /// </summary>
        [XmlRpcMember("data")]
        public string Data { get; set; }
    }
}