/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181207;

namespace Aliyun.Acs.UniMkt.Model.V20181207
{
    public class PopUpQueryRequest : RpcAcsRequest<PopUpQueryResponse>
    {
        public PopUpQueryRequest()
            : base("UniMkt", "2018-12-07", "PopUpQuery", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string optionType;

		private string extra;

		private string urlId;

		private string alipayOpenId;

		private string channelId;

		private string outerCode;

		public string OptionType
		{
			get
			{
				return optionType;
			}
			set	
			{
				optionType = value;
				DictionaryUtil.Add(BodyParameters, "OptionType", value);
			}
		}

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(BodyParameters, "Extra", value);
			}
		}

		public string UrlId
		{
			get
			{
				return urlId;
			}
			set	
			{
				urlId = value;
				DictionaryUtil.Add(BodyParameters, "UrlId", value);
			}
		}

		public string AlipayOpenId
		{
			get
			{
				return alipayOpenId;
			}
			set	
			{
				alipayOpenId = value;
				DictionaryUtil.Add(BodyParameters, "AlipayOpenId", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(BodyParameters, "ChannelId", value);
			}
		}

		public string OuterCode
		{
			get
			{
				return outerCode;
			}
			set	
			{
				outerCode = value;
				DictionaryUtil.Add(BodyParameters, "OuterCode", value);
			}
		}

        public override PopUpQueryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PopUpQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
