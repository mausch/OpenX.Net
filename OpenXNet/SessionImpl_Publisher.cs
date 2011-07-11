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
    public partial class SessionImpl {
        public Publisher AddPublisher(Publisher publisher) {
            publisher.Id = svc.AddPublisher(sessionId, publisher);
            return publisher;
        }

        public void DeletePublisher(int publisherId) {
            svc.DeletePublisher(sessionId, publisherId);
        }

        public void ModifyPublisher(Publisher publisher) {
            svc.ModifyPublisher(sessionId, publisher);
        }

        public Publisher GetPublisher(int publisherId) {
            return svc.GetPublisher(sessionId, publisherId);
        }

        public object GetPublisherAdvertiserStatistics(int publisherId, DateTime startDate, DateTime endDate) {
            return svc.GetPublisherAdvertiserStatistics(sessionId, publisherId, startDate, endDate);
        }

        public object GetPublisherCampaignStatistics(int publisherId, DateTime startDate, DateTime endDate) {
            return svc.GetPublisherCampaignStatistics(sessionId, publisherId, startDate, endDate);
        }

        public object GetPublisherDailyStatistics(int publisherId, DateTime startDate, DateTime endDate) {
            return svc.GetPublisherDailyStatistics(sessionId, publisherId, startDate, endDate);
        }

        public Publisher[] GetPublishersByManager(int managerId) {
            return svc.GetPublishersByManager(sessionId, managerId);
        }

        public object GetPublisherZoneStatistics(int publisherId, DateTime startDate, DateTime endDate) {
            return svc.GetPublisherZoneStatistics(sessionId, publisherId, startDate, endDate);
        }
    }
}
