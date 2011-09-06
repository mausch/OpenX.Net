using System;
using System.Collections.Generic;
using System.Text;

namespace OpenXNet {
    public enum RevenueType {
        /// <summary>
        /// Cost per thousand impressions
        /// </summary>
        CPM = 1, // constants from http://drupalcode.org/project/openx_manager.git/blob/59b65f12219ace1552081379dc19558c0f7e7156:/openx_manager.campaign.inc

        /// <summary>
        /// Cost per click
        /// </summary>
        CPC = 2,

        /// <summary>
        /// Cost per action
        /// </summary>
        CPA = 3,

        /// <summary>
        /// Monthly tennancy
        /// </summary>
        MT = 4,
    }
}
