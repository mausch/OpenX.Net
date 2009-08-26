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
        public Manager AddManager(Manager manager) {
            manager.Id = svc.AddManager(sessionId, manager);
            return manager;
        }

        public void DeleteManager(int managerId) {
            svc.DeleteManager(sessionId, managerId);
        }

        public Manager GetManager(int managerId) {
            return svc.GetManager(sessionId, managerId);
        }

        public void ModifyManager(Manager manager) {
            svc.ModifyManager(sessionId, manager);
        }

        public AdvertiserStats[] GetManagerAdvertiserStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerAdvertiserStatistics(sessionId, managerId, startDate, endDate);
        }

        public AdvertiserCampaignBannerStats[] GetManagerBannerStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerBannerStatistics(sessionId, managerId, startDate, endDate);
        }

        public object[] GetManagerCampaignStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerCampaignStatistics(sessionId, managerId, startDate, endDate);
        }

        public object[] GetManagerDailyStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerDailyStatistics(sessionId, managerId, startDate, endDate);
        }

        public Manager[] GetManagers() {
            return svc.GetManagers(sessionId);
        }

        public object[] GetManagerPublisherStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerPublisherStatistics(sessionId, managerId, startDate, endDate);
        }

        public object[] GetManagerZoneStatistics(int managerId, DateTime startDate, DateTime endDate) {
            return svc.GetManagerZoneStatistics(sessionId, managerId, startDate, endDate);
        }
    }
}