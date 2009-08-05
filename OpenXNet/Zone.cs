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
    public class Zone {
        [XmlRpcMember("zoneId")]
        public int Id { get; set; }

        [XmlRpcMember("zoneName")]
        public string ZoneName { get; set; }

        [XmlRpcMember("width")]
        public int Width { get; set; }

        [XmlRpcMember("height")]
        public int Height { get; set; }

        [XmlRpcMember("publisherId")]
        public int PublisherId { get; set; }

        [XmlRpcMember("capping")]
        public int Capping { get; set; }

        [XmlRpcMember("sessionCapping")]
        public int SessionCapping { get; set; }

        [XmlRpcMember("block")]
        public int Block { get; set; }

        [XmlRpcMember("comments")]
        public string Comments { get; set; }

        [XmlRpcMember("type")]
        public ZoneType Type { get; set; }
    }
}