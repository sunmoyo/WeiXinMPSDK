﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2023 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2023 Senparc
    
    文件名：Contact.cs
    文件功能描述：联系人
    
    
    创建标识：Yaofeng - 20231026

----------------------------------------------------------------*/

namespace Senparc.Weixin.Open.WxaAPIs.SecOrder
{
    /// <summary>
    /// 支付时间所属范围
    /// </summary>
    public class PayTimeRange
    {
        /// <summary>
        /// 起始时间，时间戳形式，不填则视为从0开始。
        /// </summary>
        public long begin_time { get; set; }

        /// <summary>
        /// 结束时间（含），时间戳形式，不填则视为32位无符号整型的最大值。
        /// </summary>
        public long end_time { get; set; }
    }
}