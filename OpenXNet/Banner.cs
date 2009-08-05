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
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class Banner {
        [XmlRpcMember("bannerId")]
        public int Id { get; set;}

        [XmlRpcMember("bannerName")]
        public string BannerName { get; set; }

        [XmlRpcMember("bannerText")]
        public string BannerText { get; set; }

        [XmlRpcMember("htmlTemplate")]
        public string HtmlTemplate { get; set; }

        [XmlRpcMember("height")]
        public int Height { get; set; }

        [XmlRpcMember("width")]
        public int Width { get; set; }

        /// <summary>
        /// priority weight of the banner
        /// </summary>
        [XmlRpcMember("weight")]
        public int Weight { get; set; }

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
        /// Frequency capping: total views per period.
        /// </summary>
        [XmlRpcMember("sessionCapping")]
        public int SessionCapping { get; set; }

        /// <summary>
        /// ID of the campaign to associate with the banner
        /// </summary>
        [XmlRpcMember("campaignId")]
        public int CampaignId { get; set; }

        /// <summary>
        /// Backup image name and binary data in case the primary image is a swf file
        /// </summary>
        [XmlRpcMember("aBackupImage")]
        public BannerImage[] BackupImages { get; set; }

        [XmlRpcMember("aImage")]
        public BannerImage Image { get; set; }

        /// <summary>
        /// A text field for HTML banners to indicate which adserver this ad is from
        /// </summary>
        [XmlRpcMember("adServer")]
        public string AdServer { get; set; }

        /// <summary>
        /// This field provides the URL for the image file for an external banner.
        /// </summary>
        [XmlRpcMember("imageURL")]
        public string ImageUrl { get; set; }

        [XmlRpcMember("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Indicate if the banner is active
        /// </summary>
        [XmlRpcMember("status")]
        public int Status { get; set; }

        /// <summary>
        /// HTML target of the banner (e.g. _blank, _self)
        /// </summary>
        [XmlRpcMember("target")]
        public string Target { get; set; }

        /// <summary>
        /// Storage type for the banner, which is one of 'sql','web','url','html','txt'.
        /// </summary>
        [XmlRpcMember("storageType")]
        public string StorageType { get; set; }

        /// <summary>
        /// Transparency information for SWF banners
        /// </summary>
        [XmlRpcMember("transparent")]
        public int Transparent { get; set; }

        /// <summary>
        /// Destination URL of the banner.
        /// </summary>
        [XmlRpcMember("url")]
        public string Url { get; set; }
    }
}