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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class TransferPayTypeRequest : RpcAcsRequest<TransferPayTypeResponse>
    {
        public TransferPayTypeRequest()
            : base("Dts", "2020-01-01", "TransferPayType", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string period;

		private string buyCount;

		private string dtsJobId;

		private string chargeType;

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string BuyCount
		{
			get
			{
				return buyCount;
			}
			set	
			{
				buyCount = value;
				DictionaryUtil.Add(QueryParameters, "BuyCount", value);
			}
		}

		public string DtsJobId
		{
			get
			{
				return dtsJobId;
			}
			set	
			{
				dtsJobId = value;
				DictionaryUtil.Add(QueryParameters, "DtsJobId", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TransferPayTypeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TransferPayTypeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
