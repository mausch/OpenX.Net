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

using System;

namespace OpenXNet {
    public partial interface ISession {
        Publisher AddPublisher(Publisher publisher);

        void DeletePublisher(int publisherId);

        void ModifyPublisher(Publisher publisher);

        Publisher GetPublisher(int publisherId);

        object GetPublisherAdvertiserStatistics(int publisherId, DateTime startDate, DateTime endDate);

        object GetPublisherCampaignStatistics(int publisherId, DateTime startDate, DateTime endDate);

        object GetPublisherDailyStatistics(int publisherId, DateTime startDate, DateTime endDate);

        Publisher[] GetPublishersByManager(int managerId);

        object GetPublisherZoneStatistics(int publisherId, DateTime startDate, DateTime endDate);
    }
}
