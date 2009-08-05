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
    public class BannerRepository : AbstractCRUDRepository<Banner>, IBannerRepository {
        public BannerRepository(ISession session) : base(session) {}

        public override Banner Add(Banner entity) {
            var id = session.Svc.AddBanner(session.SessionId, entity);
            entity.Id = id;
            return entity;
        }

        public override Banner Update(Banner entity) {
            session.Svc.ModifyBanner(session.SessionId, entity);
            return entity;
        }

        public override void Delete(int id) {
            session.Svc.DeleteBanner(session.SessionId, id);
        }

        public override Banner Get(int id) {
            return session.Svc.GetBanner(session.SessionId, id);
        }

        public Banner[] GetBannersByCampaign(int campaignId) {
            return session.Svc.GetBannersByCampaign(session.SessionId, campaignId);
        }

        public object[] GetBannerDailyStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return session.Svc.GetBannerDailyStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerPublisherStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return session.Svc.GetBannerPublisherStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public object[] GetBannerZoneStatistics(int bannerId, DateTime startDate, DateTime endDate) {
            return session.Svc.GetBannerZoneStatistics(session.SessionId, bannerId, startDate, endDate);
        }

        public BannerTargeting[] GetBannerTargeting(int bannerId) {
            return session.Svc.GetBannerTargeting(session.SessionId, bannerId);
        }

        public void SetBannerTargeting(int bannerId, BannerTargeting[] targeting) {
            session.Svc.SetBannerTargeting(session.SessionId, bannerId, targeting);
        }
    }
}