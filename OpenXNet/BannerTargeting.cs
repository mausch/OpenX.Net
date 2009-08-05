#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

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